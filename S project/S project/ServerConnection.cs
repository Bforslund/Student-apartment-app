using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ServerLibrary;
using System.Threading;

namespace S_project
{
    public class ServerConnection
    {
        private TcpClient tcp;
        public static bool Connected = false;
        private int udpServerPort = 6000;

        #region Getting/Updating data on the server
        //Returns user information if credentials are correct
        public UserInfo CheckUser(string login, string password, int houseNumber)
        {
            Wait(25);

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

        public bool CreateNewUser(ServerUser newUser)
        {
            Wait(25);

            string json = JsonConvert.SerializeObject(newUser);

            PackageType[] receivedTypes = new PackageType[2] { PackageType.USER_EXISTS, PackageType.USER_CREATED };

            ServerPackage package = GetResponce(PackageType.CREATE_NEW_USER, receivedTypes, json);

            switch (package.Type)
            {
                case PackageType.USER_CREATED:
                    return true;
                default:
                    return false;
            }
        }

        public Dictionary<int, string> GetUsersInfo(int houseNumber)
        {
            Wait(25);

            string message = GetResponce(PackageType.GET_ALL_USERS, PackageType.ALL_USERS, houseNumber.ToString());
            return JsonConvert.DeserializeObject<Dictionary<int, string>>(message);
        }

        //Updates password
        public bool UpdatePassword(int id, string newPassword, string currentPassword, int houseNumber)
        {
            Wait(25);

            string json = JsonConvert.SerializeObject(new PasswordChange(id, newPassword, currentPassword, houseNumber));

            PackageType[] receivedTypes = new PackageType[2] { PackageType.PASSWORD_CHANGED, PackageType.INVALID_DATA };

            ServerPackage package = GetResponce(PackageType.UPDATE_PASSWORD, receivedTypes, json);

            switch (package.Type)
            {
                case PackageType.PASSWORD_CHANGED:
                    return true;
                default:
                    return false;
            }
        }

        //Returns all house rules for this house
        public HouseRules GetHouseRules(int houseNumber)
        {
            Wait(25);

            string message = GetResponce(PackageType.GET_HOUSE_RULES, PackageType.HOUSE_RULES, houseNumber.ToString());
            return JsonConvert.DeserializeObject<HouseRules>(message);
        }

        public bool UpdateHouseRules(HouseRules houseRules)
        {
            Wait(25);

            string json = JsonConvert.SerializeObject(houseRules, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_HOUSE_RULES, PackageType.RECEIVED, json);
            return true;
        }

        //Returns all mandatory rules
        public MandatoryRules GetMandatoryRules(int houseNumber)
        {
            Wait(25);

            string message = GetResponce(PackageType.GET_MANDATORY_RULES, PackageType.MANDATORY_RULES, houseNumber.ToString());
            return JsonConvert.DeserializeObject<MandatoryRules>(message);
        }

        public void UpdateMandatoryRules(MandatoryRules mandatoryRules)
        {
            Wait(25);

            string json = JsonConvert.SerializeObject(mandatoryRules, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_MANDATORY_RULES, PackageType.RECEIVED, json);
            
        }

        //Returns all complaints
        public Complaints GetComplaints(int houseNumber)
        {
            Wait(25);

            string message = GetResponce(PackageType.GET_COMPLAINTS, PackageType.COMPLAINTS, houseNumber.ToString());
            return JsonConvert.DeserializeObject<Complaints>(message);
        }

        public bool UpdateComplaints(Complaints complaints)
        {
            Wait(25);

            string json = JsonConvert.SerializeObject(complaints, Formatting.Indented);

            string message = GetResponce(PackageType.UPDATE_COMPLAINTS, PackageType.RECEIVED, json);
            return true;
        }

        //Returns all Chat messages
        public ChatHistory GetMessages(int houseNumber)
        {
            Wait(25);

            string message = GetResponce(PackageType.GET_MESSAGES, PackageType.MESSAGES, houseNumber.ToString());
            return JsonConvert.DeserializeObject<ChatHistory>(message);
        }

        public bool UpdateMessages(ChatHistory msg)
        {
            Wait(25);

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
        }

        //Packs everything so that server can understand
        private string GetResponce(PackageType sendType, PackageType receivedType, string data)
        {
            while (true)
            {
                Connected = true;

                ServerPackage serverPackage = new ServerPackage(sendType, data, this.udpServerPort);
                string json = JsonConvert.SerializeObject(serverPackage, Formatting.Indented);

                SendToServer(json);

                string message = "";
                int attempts = 0;

                while (true)
                {
                    message += ReadFromServer();
                    message = message.Replace("\0", "");
                    
                    if (attempts < 15)
                    {
                        attempts++;
                    }
                    else
                    {
                        break;
                    }                

                    if (message.Length > 1)
                    {
                        ServerPackage package = JsonConvert.DeserializeObject<ServerPackage>(message);

                        if (package.Type == receivedType)
                        {
                            tcp.Close();
                            Connected = false;

                            return package.Message;
                        }
                        else { continue; }
                    }
                }
            }
        }

        private ServerPackage GetResponce(PackageType sendType, PackageType[] receivedTypes, string data)
        {
            while (true)
            {
                Connected = true;

                ServerPackage serverPackage = new ServerPackage(sendType, data, this.udpServerPort);
                string json = JsonConvert.SerializeObject(serverPackage, Formatting.Indented);

                SendToServer(json);

                string message = "";
                int attempts = 0;

                while (true)
                {
                    message += ReadFromServer();
                    message = message.Replace("\0", "").Trim();

                    if (attempts < 15)
                    {
                        attempts++;
                    }
                    else
                    {
                        break;
                    }

                    if (message.Length > 1)
                    {
                        ServerPackage package = JsonConvert.DeserializeObject<ServerPackage>(message);

                        if (receivedTypes.Contains(package.Type))
                        {
                            tcp.Close();
                            Connected = false;
                            return package;
                        }
                        else { continue; }
                    }
                }
            }
        }
        
        //Reads server responce
        private string ReadFromServer()
        {
            //Third attempt
            string answer = "";
            int dataLength;
            int bytesRead = 0;
            int count = 0;
            bool end = false;
            byte[] msg;

            byte[] border = new byte[1];
            tcp.GetStream().Read(border, 0, 1);

            if (border[0] != 12) // 12 - indicates that it is a start of the message
                return "";

            byte[] numOfBytes = new byte[4];
            tcp.GetStream().Read(numOfBytes, 0, 4);
            dataLength = BitConverter.ToInt32(numOfBytes, 0);

            while (true)
            {
                Thread.Sleep(25);

                msg = new byte[dataLength];
                bytesRead = tcp.GetStream().Read(msg, 0, msg.Length);

                if (msg[bytesRead - 1] == 13)
                {
                    msg[bytesRead - 1] = 0;
                    end = true;
                }

                answer += Encoding.Default.GetString(msg, 0, msg.Length);
                answer = answer.Replace("\0", "");

                count += bytesRead;
                if (count == dataLength)
                {
                    tcp.GetStream().Read(border, 0, 1);

                    if (border[0] != 13) // 13 - indicates that it is the end of the message
                    {
                        if (msg.Last() != 13)
                            continue;
                    }
                    break;
                }
                else if(count > dataLength && end)
                {
                    break;
                }
            }

            return answer;
        }
        #endregion

        #region Helpers
        public int GetAvailableUdpPort()
        {
            int port = 6000;
            UdpClient udpClient = new UdpClient();

            while (true)
            {
                try
                {
                    udpClient.Client.Bind(new IPEndPoint(0, port));
                    break;
                }
                catch
                {
                    port++;
                    continue;
                }
            }

            udpClient.Close();
            this.udpServerPort = port;
            return port;
        }

        public void Wait(int interval)
        {
            while (ServerConnection.Connected)
                Thread.Sleep(interval);
        }
        #endregion
    }
}
