using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class ServerMain
    {
        const int SLEEP_INTERVAL = 100;
        private TcpListener clientListener;
        private List<TcpClient> clients = new List<TcpClient>();

        public ServerMain()
        {
            //Listen on port 7800 for new TCP clients
            clientListener = new TcpListener(IPAddress.Any, 7800);
            clientListener.Start();

            //Task which waits and adds new clients asynchroniously
            Task.Run(async () =>
            {
                while (true)
                {
                    clients.Add(await clientListener.AcceptTcpClientAsync());
                    Console.Write($"Clients Connected - {clients.Count}\n");
                }
            });

            //Task which shares every 0.5 seconds server IP
            Task.Run(() =>
            {
                while (true)
                {
                    UdpClient client = new UdpClient();
                    client.Client.Bind(new IPEndPoint(0, 5643));

                    while (true)
                    {
                        try
                        {
                            string message = "Hello world!";
                            byte[] data = Encoding.UTF8.GetBytes(message);

                            for (int i = 5800; i < 5850; i++)
                            {
                                client.Send(data, data.Length, "255.255.255.255", i);
                            }

                            //Waits for 0.5 seconds
                            Thread.Sleep(SLEEP_INTERVAL);
                        }
                        catch
                        {
                            client.Client.Dispose();
                            break;
                        }
                    }
                }
            });
        }

        //Starts server 
        public void Start()
        {
            //Main loop
            while (true)
            {
                Thread.Sleep(SLEEP_INTERVAL);
                try
                {
                    //Checks each connected client, if it has any messages
                    foreach (var client in clients)
                    {
                        int index = clients.IndexOf(client);

                        try
                        {
                            byte[] mssg = new byte[1];
                            client.GetStream().Write(mssg, 0, mssg.Length);

                        }
                        catch { CloseTcpConection(index); }

                        if (client != null && client.Connected)
                        {
                            NetworkStream ns = client.GetStream();

                            if (client.Available > 0)
                            {
                                string message = "";
                                List<byte> Buf = new List<byte>();

                                while (ns.DataAvailable)
                                {
                                    byte[] msg = new byte[1024];
                                    int count = ns.Read(msg, 0, msg.Length);
                                    Buf.AddRange(msg.Take(count));
                                }

                                message = Encoding.Default.GetString(Buf.ToArray(), 0, Buf.Count);

                                ServerPackage package = JsonConvert.DeserializeObject<ServerPackage>(message);

                                //Task.Run(() => 
                                //{
                                HandleDataQuery(client, package);
                                //});
                            }
                        }
                    }
                }
                catch { Console.WriteLine($"Clients Connected - {clients.Count}\n"); }
            }
        }

        //Closes TCP connection
        private void CloseTcpConection(int index)
        {
            clients[index].Close();
            clients.RemoveAt(index);
        }

        private void CheckExistedFiles(int houseNumber)
        {
            if (!Directory.Exists(@$"data\house-{houseNumber}"))
                Directory.CreateDirectory(@$"data\house-{houseNumber}");
            if (!File.Exists(@$"data\house-{houseNumber}\house-rules.json"))
            {
                HouseRules houseRules = new HouseRules
                {
                    HouseNumber = houseNumber,
                    AllRules = new List<HouseRule>()
                };

                File.WriteAllText(@$"data\house-{houseNumber}\house-rules.json",
                    JsonConvert.SerializeObject(houseRules, Formatting.Indented));
            }
            if (!File.Exists(@$"data\house-{houseNumber}\mandatory-rules.json"))
            {
                MandatoryRules houseRules = new MandatoryRules
                {
                    HouseNumber = houseNumber,
                    AllRules = new List<MandatoryRule>()
                };

                File.WriteAllText(@$"data\house-{houseNumber}\mandatory-rules.json",
                    JsonConvert.SerializeObject(houseRules, Formatting.Indented));
            }
            if (!File.Exists(@$"data\house-{houseNumber}\students.json"))
            {
                Users users = new Users
                {
                    TotalStudentNumber = 0,
                    AllUsers = new List<ServerUser>()
                };

                File.WriteAllText(@$"data\house-{houseNumber}\students.json",
                    JsonConvert.SerializeObject(users, Formatting.Indented));
            }
            if (!File.Exists(@$"data\house-{houseNumber}\complaints.json"))
            {
                Complaints complaints = new Complaints
                {
                    HouseNumber = houseNumber,
                    AllComplaints = new List<Complaint>()
                };

                File.WriteAllText(@$"data\house-{houseNumber}\complaints.json",
                    JsonConvert.SerializeObject(complaints, Formatting.Indented));
            }
        }

        //Handles received packages based on their types
        private void HandleDataQuery(TcpClient client, ServerPackage package)
        {
            switch (package.Type)
            {
                case PackageType.USER_CHECK:
                    {
                        if (!CheckUserInfo(client, JsonConvert.DeserializeObject<UserCheck>(package.Message)))
                            SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.INVALID_DATA, "")));
                        break;
                    }
                case PackageType.GET_HOUSE_RULES:
                    {
                        CheckExistedFiles(Convert.ToInt32(package.Message));

                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.HOUSE_RULES,
                            File.ReadAllText(@$"data\house-{package.Message}\house-rules.json"))));
                        break;
                    }
                case PackageType.UPDATE_HOUSE_RULES:
                    {
                        HouseRules houseRules = JsonConvert.DeserializeObject<HouseRules>(package.Message);

                        CheckExistedFiles(Convert.ToInt32(houseRules.HouseNumber));

                        File.WriteAllText(@$"data\house-{houseRules.HouseNumber}\house-rules.json", package.Message);

                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "")));
                        break;
                    }
                case PackageType.GET_MANDATORY_RULES:
                    {
                        CheckExistedFiles(Convert.ToInt32(package.Message));

                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.MANDATORY_RULES,
                            File.ReadAllText(@$"data\house-{package.Message}\mandatory-rules.json"))));
                        break;
                    }
                case PackageType.UPDATE_MANDATORY_RULES:
                    {
                        MandatoryRules mandatoryRules = JsonConvert.DeserializeObject<MandatoryRules>(package.Message);

                        CheckExistedFiles(Convert.ToInt32(mandatoryRules.HouseNumber));

                        File.WriteAllText(@$"data\house-{mandatoryRules.HouseNumber}\mandatory-rules.json", package.Message);

                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "")));
                        break;
                    }
                case PackageType.GET_COMPLAINTS:
                    {
                        CheckExistedFiles(Convert.ToInt32(package.Message));

                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.COMPLAINTS,
                            File.ReadAllText(@$"data\house-{package.Message}\complaints.json"))));
                        break;
                    }
                case PackageType.UPDATE_COMPLAINTS:
                    {
                        MandatoryRules mandatoryRules = JsonConvert.DeserializeObject<MandatoryRules>(package.Message);

                        CheckExistedFiles(Convert.ToInt32(mandatoryRules.HouseNumber));

                        File.WriteAllText(@$"data\house-{mandatoryRules.HouseNumber}\complaints.json", package.Message);

                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "")));
                        break;
                    }
            }
        }

        //Checks if login and password are correct
        private bool CheckUserInfo(TcpClient client, UserCheck userCheck)
        {
            CheckExistedFiles(Convert.ToInt32(userCheck.HouseNumber));

            Users users = JsonConvert.DeserializeObject<Users>(File.ReadAllText(@$"data\house-{userCheck.HouseNumber}\students.json"));

            foreach (var user in users.AllUsers)
            {
                if (user.Login == userCheck.Login && user.Password == userCheck.Password && user.HouseNumber == userCheck.HouseNumber)
                {
                    Dictionary<string, int> usersInfo = new Dictionary<string, int>();

                    foreach (var u in users.AllUsers)
                    {
                        usersInfo.Add(u.Name, u.ID);
                    }

                    List<string> s = users.AllUsers.ConvertAll(x => x.Name);

                    UserInfo userInfo = new UserInfo()
                    {
                        Type = user.Type,
                        ID = user.ID,
                        Name = user.Name,
                        LastName = user.LastName,
                        HouseNumber = user.HouseNumber,
                        Room = user.Room,
                        TotalStudentNumber = users.TotalStudentNumber,
                        StudentsInfo = usersInfo
                    };

                    string json = JsonConvert.SerializeObject(userInfo);

                    SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.USER_INFO, json)));
                    return true;
                }
            }

            return false;
        }

        //Send message to the specified client
        private void SendMessage(TcpClient client, string message)
        {
            byte[] Buffer;
            Buffer = Encoding.Default.GetBytes(message);
            client.GetStream().Write(Buffer, 0, Buffer.Length);
            client.Close();
        }

        static void Main(string[] args)
        {
            ServerMain svc = new ServerMain();
            svc.Start();
        }
    }
}
