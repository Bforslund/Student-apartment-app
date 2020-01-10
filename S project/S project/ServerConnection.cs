﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ServerLibrary;

namespace S_project
{
    public class ServerConnection
    {
        private TcpClient tcp;

        #region Getting/Updating data on the server
        //Returns user information if credentials are correct
        public UserInfo CheckUser(string login, string password, int houseNumber)
        {
            string json = JsonConvert.SerializeObject(new UserCheck(login, password, houseNumber));

            PackageType[] receivedTypes = new PackageType[2] { PackageType.USER_INFO, PackageType.INVALID_DATA };

            ServerPackage package = GetResponce(PackageType.USER_CHECK, receivedTypes, json);

            switch (package.Type)
            {
                case PackageType.USER_INFO:
                    return JsonConvert.DeserializeObject<UserInfo>(package.Message);
                default:
                    return null;
            }
        }

        //Returns all house rules for this house
        public HouseRules GetHouseRules(int houseNumber)
        {
            string message = GetResponce(PackageType.GET_HOUSE_RULES, PackageType.HOUSE_RULES, houseNumber.ToString());
            return JsonConvert.DeserializeObject<HouseRules>(message);
        }

        public bool UpdateHouseRules(HouseRules houseRules)
        {
            string json = JsonConvert.SerializeObject(houseRules, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_HOUSE_RULES, PackageType.RECEIVED, json);
            return true;
        }

        //Returns all mandatory rules
        public MandatoryRules GetMandatoryRules(int houseNumber)
        {
            string message = GetResponce(PackageType.GET_MANDATORY_RULES, PackageType.MANDATORY_RULES, houseNumber.ToString());
            return JsonConvert.DeserializeObject<MandatoryRules>(message);
        }

        public void UpdateMandatoryRules(MandatoryRules mandatoryRules)
        {
            string json = JsonConvert.SerializeObject(mandatoryRules, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_MANDATORY_RULES, PackageType.RECEIVED, json);
            
        }

        //Returns all complaints
        public Complaints GetComplaints(int houseNumber)
        {
            string message = GetResponce(PackageType.GET_COMPLAINTS, PackageType.COMPLAINTS, houseNumber.ToString());
            return JsonConvert.DeserializeObject<Complaints>(message);
        }

        public bool UpdateComplaints(Complaints complaints)
        {
            string json = JsonConvert.SerializeObject(complaints, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_COMPLAINTS, PackageType.RECEIVED, json);
            return true;
        }

        //Returns all Chat messages
        public ChatHistory GetMessages(int houseNumber)
        {
            string message = GetResponce(PackageType.GET_MESSAGES, PackageType.MESSAGES, houseNumber.ToString());
            return JsonConvert.DeserializeObject<ChatHistory>(message);
        }

        public bool UpdateMessages(ChatHistory msg)
        {
            string json = JsonConvert.SerializeObject(msg, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_MESSAGES, PackageType.RECEIVED, json);
            return true;
        }
        #endregion

        #region Communication with the server
        //Connects to the server and sends pacckages
        private void SendToServer(string message)
        {
            UdpClient client = new UdpClient();
            IPEndPoint remoteIp = null;

            //Reads 50 known UDP ports for a broadcast message with serve IP
            while (remoteIp == null)
            {
                for (int i = 5800; i < 5850; i++)
                {
                    try
                    {
                        client.Client.Bind(new IPEndPoint(0, i));
                    }
                    catch { continue; }

                    client.Receive(ref remoteIp);

                    if (remoteIp != null)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            client.Close();

            //Connects to TCP server using acquired IP
            tcp = new TcpClient();
            tcp.Connect(remoteIp.Address, 7800);

            //Sends package to the server
            byte[] Buffer;
            Buffer = Encoding.Default.GetBytes(message);
            tcp.GetStream().Write(Buffer, 0, Buffer.Length);

            //Starts waiting for a response
            //BeginReading();
        }

        //Packs everything so that server can understand
        private string GetResponce(PackageType sendType, PackageType receivedType, string data)
        {
            ServerPackage serverPackage = new ServerPackage(sendType, data);
            string json = JsonConvert.SerializeObject(serverPackage, Formatting.Indented);

            SendToServer(json);

            string message = "";

            while (true)
            {
                message = ReadFromServer();

                if (message.Length > 1)
                {
                    ServerPackage package = JsonConvert.DeserializeObject<ServerPackage>(message);

                    if (package.Type == receivedType)
                    {
                        tcp.Close();
                        return package.Message;
                    }
                    else { continue; }
                }
            }
        }

        private ServerPackage GetResponce(PackageType sendType, PackageType[] receivedTypes, string data)
        {
            ServerPackage serverPackage = new ServerPackage(sendType, data);
            string json = JsonConvert.SerializeObject(serverPackage, Formatting.Indented);

            SendToServer(json);

            string message = "";

            while (true)
            {
                message = ReadFromServer();

                if (message.Length > 1)
                {
                    ServerPackage package = JsonConvert.DeserializeObject<ServerPackage>(message);

                    if (receivedTypes.Contains(package.Type))
                    {
                        tcp.Close();
                        return package;
                    }
                    else { continue; }
                }
            }
        }

        //Reads server responce
        private string ReadFromServer()
        {
            List<byte> Buf = new List<byte>();
            tcp.GetStream().ReadTimeout = 20;
            //int count = 2;

            while (tcp.GetStream().DataAvailable)
            {
                byte[] msg = new byte[1024];
                int count = tcp.GetStream().Read(msg, 0, msg.Length);
                Buf.AddRange(msg.Take(count));
            }

            //byte[] msg = new byte[1000000];

            //int count = 0;

            //while(count > 1)
            //{
            //    count += tcp.GetStream().Read(msg, 0, msg.Length);
            //}
            //int count = tcp.GetStream().Read(msg, 0, msg.Length);

            //return Encoding.Default.GetString(Buf.ToArray(), 0, Buf.Count);

            return Encoding.Default.GetString(Buf.ToArray(), 0, Buf.Count);
        }
        #endregion 
    }
}
