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
using ServerLibrary;

namespace Server
{
    class ServerMain
    {
        const int SLEEP_INTERVAL = 100; //Update interval
        private TcpListener clientListener; //Listens for new conections
        private List<TcpClient> clients = new List<TcpClient>(); //List of all currently connected clients
        private List<int> udpServerPorts = new List<int>(); //List of all usdp server ports to which clients are connected
        public ServerMain()
        {
            //Listen on port 7800 for new TCP clients
            clientListener = new TcpListener(IPAddress.Any, 7800);
            //Start listener
            clientListener.Start(); 

            //Task which waits and adds new clients asynchroniously(in another thread)
            Task.Run(async () =>
            {
                while (true)
                {
                    //Thread won't go farver until new client is connected
                    clients.Add(await clientListener.AcceptTcpClientAsync()); 
                    Console.WriteLine($"Clients Connected (normal) - {clients.Count}\n");
                }
            });

            //Task which shares every 0.5 seconds server IP
            Task.Run(() =>
            {
                while (true)
                {
                    //Creates a Udp client and assigns it port 5643
                    UdpClient client = new UdpClient();
                    client.Client.Bind(new IPEndPoint(0, 5643));

                    //In while loop broadcast message with server IP
                    while (true)
                    {
                        try
                        {
                            string message = "Hello world!";
                            byte[] data = Encoding.UTF8.GetBytes(message);

                            //Broadcsts on 50 ports
                            for (int i = 5800; i < 5850; i++)
                            {
                                client.Send(data, data.Length, "255.255.255.255", i);
                            }

                            //Waits for given interval
                            Thread.Sleep(SLEEP_INTERVAL);
                        }
                        catch
                        {
                            //If there are any errors we dispose current server and create another one
                            client.Client.Dispose();
                            break;
                        }
                    }
                }
            });

            Console.WriteLine("Waiting for clients...\n");
        }

        //Starts server 
        public void Start()
        {
            //Main loop
            while (true)
            {
                //Waits for given interval
                Thread.Sleep(SLEEP_INTERVAL);
                try
                {
                    //Checks each connected client, if it has any messages
                    foreach (var client in clients)
                    {
                        int index = clients.IndexOf(client); //Gets index of the client

                        //Tryes to send an one-byte message to check if client is connected from both sides
                        try
                        {
                            byte[] mssg = new byte[1];
                            client.GetStream().Write(mssg, 0, mssg.Length);

                        }
                        //If is not able to send message disconnect client
                        catch { CloseTcpConection(index); }

                        if (client != null && client.Connected)
                        {
                            NetworkStream ns = client.GetStream(); //Gets client stream

                            //If there is any data to read
                            if (client.Available > 0)
                            {
                                string message = "";
                                List<byte> Buf = new List<byte>();

                                //Reads in while loop all the data 
                                while (ns.DataAvailable)
                                {
                                    byte[] msg = new byte[1024];
                                    int count = ns.Read(msg, 0, msg.Length);
                                    Buf.AddRange(msg.Take(count));
                                }

                                //Decodes message to a string 
                                message = Encoding.Default.GetString(Buf.ToArray(), 0, Buf.Count);

                                //Deserializes message into a ServerPackage
                                ServerPackage package = JsonConvert.DeserializeObject<ServerPackage>(message);

                                Console.WriteLine(Convert.ToString(package.Type));

                                //Handles received package
                                HandleDataQuery(client, package);
                            }
                        }
                    }
                }
                catch 
                { 
                    Console.Write($"Clients Connected (catch) - {clients.Count} \n");
                }
            }
        }

        //Closes TCP connection
        private void CloseTcpConection(int index)
        {
            clients[index].Close(); //closes client
            clients.RemoveAt(index); //remove client from global clients list
        }

        //Checks if needed files/directories exist
        //Creates new files if it is needed
        private void CheckExistedFiles(int houseNumber)
        {
            //Checks if directory for this house exists
            if (!Directory.Exists(@$"data/house-{houseNumber}"))
                //Creates new directory
                Directory.CreateDirectory(@$"data/house-{houseNumber}");

            //Checks if file for house rules exists
            if (!File.Exists(@$"data/house-{houseNumber}/house-rules.json"))
            {
                //Creates a new object with zero rules
                HouseRules houseRules = new HouseRules
                {
                    HouseNumber = houseNumber,
                    AllRules = new List<HouseRule>()
                };

                //Saves new file
                File.WriteAllText(@$"data/house-{houseNumber}/house-rules.json",
                    JsonConvert.SerializeObject(houseRules, Formatting.Indented));
            }

            //Checks if file for mandatory rules exists
            if (!File.Exists(@$"data/house-{houseNumber}/mandatory-rules.json"))
            {
                //Creates a new object with zero rules
                MandatoryRules houseRules = new MandatoryRules
                {
                    HouseNumber = houseNumber,
                    AllRules = new List<MandatoryRule>()
                };

                //Saves new file
                File.WriteAllText(@$"data/house-{houseNumber}/mandatory-rules.json",
                    JsonConvert.SerializeObject(houseRules, Formatting.Indented));
            }

            //Checks if file for users exists
            if (!File.Exists(@$"data/house-{houseNumber}/students.json"))
            {
                //Creates a new object with zero users
                Users users = new Users
                {
                    TotalStudentNumber = 0,
                    AllUsers = new List<ServerUser>()
                };

                //Saves new file
                File.WriteAllText(@$"data/house-{houseNumber}/students.json",
                    JsonConvert.SerializeObject(users, Formatting.Indented));
            }

            //Checks if file for complaints rules exists
            if (!File.Exists(@$"data/house-{houseNumber}/complaints.json"))
            {
                //Creates a new object with zero complaints
                Complaints complaints = new Complaints
                {
                    HouseNumber = houseNumber,
                    AllComplaints = new List<Complaint>()
                };

                //Saves new file
                File.WriteAllText(@$"data/house-{houseNumber}/complaints.json",
                    JsonConvert.SerializeObject(complaints, Formatting.Indented));
            }
            if (!File.Exists(@$"data/house-{houseNumber}/messages.json"))
            {
                //Creates a new object with zero complaints
                ChatHistory messages = new ChatHistory
                {
                    HouseNumber = houseNumber,
                    AllMessages = new List<ChatMessage>()
                };

                //Saves new file
                File.WriteAllText(@$"data/house-{houseNumber}/messages.json",
                    JsonConvert.SerializeObject(messages, Formatting.Indented));
            }
        }

        //Handles received packages based on their types
        private void HandleDataQuery(TcpClient client, ServerPackage package)
        {
            //Based on the package type returns needed information
            switch (package.Type)
            {
                case PackageType.USER_CHECK:
                    {
                        CheckUdp(package.UdpServerPort);

                        //Checks if user with given credentials exists
                        if (!CheckUserInfo(client, JsonConvert.DeserializeObject<UserCheck>(package.Message)))
                            //Sends "invalid data" error if user doesn't exist
                            SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.INVALID_DATA, "", -1)));
                        break;
                    }
                case PackageType.GET_HOUSE_RULES:
                    {
                        //Checks if needed files/directories exist
                        CheckExistedFiles(Convert.ToInt32(package.Message));
                        CheckUdp(package.UdpServerPort);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.HOUSE_RULES,
                            File.ReadAllText(@$"data/house-{package.Message}/house-rules.json"), -1)));
                        break;
                    }
                case PackageType.UPDATE_HOUSE_RULES:
                    {
                        HouseRules houseRules = JsonConvert.DeserializeObject<HouseRules>(package.Message);
                        
                        //Checks if needed files/directories exist
                        CheckExistedFiles(Convert.ToInt32(houseRules.HouseNumber));
                        CheckUdp(package.UdpServerPort);

                        //Update file
                        File.WriteAllText(@$"data/house-{houseRules.HouseNumber}/house-rules.json", package.Message);

                        SendUpdated(package.UdpServerPort);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "", -1)));
                        break;
                    }
                case PackageType.GET_MANDATORY_RULES:
                    {
                        //Checks if needed files/directories exist
                        CheckExistedFiles(Convert.ToInt32(package.Message));
                        CheckUdp(package.UdpServerPort);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.MANDATORY_RULES,
                            File.ReadAllText(@$"data/house-{package.Message}/mandatory-rules.json"), -1)));
                        break;
                    }
                case PackageType.UPDATE_MANDATORY_RULES:
                    {
                        MandatoryRules mandatoryRules = JsonConvert.DeserializeObject<MandatoryRules>(package.Message);

                        //Checks if needed files/directories exist
                        CheckExistedFiles(Convert.ToInt32(mandatoryRules.HouseNumber));
                        CheckUdp(package.UdpServerPort);

                        SendUpdated(package.UdpServerPort);

                        //Update file
                        File.WriteAllText(@$"data/house-{mandatoryRules.HouseNumber}/mandatory-rules.json", package.Message);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "", -1)));
                        break;
                    }
                case PackageType.GET_COMPLAINTS:
                    {
                        //Checks if needed files/directories exist
                        CheckExistedFiles(Convert.ToInt32(package.Message));
                        CheckUdp(package.UdpServerPort);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.COMPLAINTS,
                            File.ReadAllText(@$"data/house-{package.Message}/complaints.json"), -1)));
                        break;
                    }
                case PackageType.UPDATE_COMPLAINTS:
                    {
                        MandatoryRules mandatoryRules = JsonConvert.DeserializeObject<MandatoryRules>(package.Message);

                        //Checks if needed files/directories 
                        CheckExistedFiles(Convert.ToInt32(mandatoryRules.HouseNumber));
                        CheckUdp(package.UdpServerPort);

                        SendUpdated(package.UdpServerPort);

                        //Update file
                        File.WriteAllText(@$"data/house-{mandatoryRules.HouseNumber}/complaints.json", package.Message);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "", -1)));
                        break;
                    }
                case PackageType.GET_MESSAGES:
                    {
                        //Checks if needed files/directories exist
                        CheckExistedFiles(Convert.ToInt32(package.Message));
                        CheckUdp(package.UdpServerPort);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.MESSAGES,
                            File.ReadAllText(@$"data/house-{package.Message}/messages.json"), -1)));
                        break;
                    }
                case PackageType.UPDATE_MESSAGES:
                    {
                        ChatHistory chathistory = JsonConvert.DeserializeObject<ChatHistory>(package.Message);

                        //Checks if needed files/directories 
                        CheckExistedFiles(Convert.ToInt32(chathistory.HouseNumber));
                        CheckUdp(package.UdpServerPort);

                        //Update file
                        File.WriteAllText(@$"data/house-{chathistory.HouseNumber}/messages.json", package.Message);

                        SendUpdated(package.UdpServerPort);

                        //Sends responce
                        SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.RECEIVED, "", -1)));
                        break;
                    }
            }
        }

        //Checks if login and password are correct
        private bool CheckUserInfo(TcpClient client, UserCheck userCheck)
        {
            //Checks if needed files/directories exist
            CheckExistedFiles(Convert.ToInt32(userCheck.HouseNumber));

            Users users = JsonConvert.DeserializeObject<Users>(File.ReadAllText(@$"data/house-{userCheck.HouseNumber}/students.json"));

            //For each user check if given credentials corespond to anyone
            foreach (var user in users.AllUsers)
            {
                if (user.Login == userCheck.Login && user.Password == userCheck.Password && user.HouseNumber == userCheck.HouseNumber)
                {
                    Dictionary<int, string> usersInfo = new Dictionary<int, string>();

                    //Adds all student's Name and ID in a dictionary
                    foreach (var u in users.AllUsers)
                    {
                        usersInfo.Add(u.ID, u.Name);
                    }

                    List<string> s = users.AllUsers.ConvertAll(x => x.Name);

                    //Generates new object with all needed info as a responce
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

                    //Sends responce
                    SendMessage(client, JsonConvert.SerializeObject(new ServerPackage(PackageType.USER_INFO, json, -1)));
                    return true;
                }
            }

            return false;
        }

        private void CheckUdp(int udpServerPort)
        {
            if (!udpServerPorts.Any(x => x == udpServerPort))
                udpServerPorts.Add(udpServerPort);
        }

        //Informs client that something was updated
        private void SendUpdated(int udpServerPort)
        {
            byte[] data = Encoding.UTF8.GetBytes("Updated");
            UdpClient udpClient = new UdpClient();

            foreach(int port in udpServerPorts)
                udpClient.Send(data, data.Length, "255.255.255.255", port);
        }

        //Send message to the specified client
        private void SendMessage(TcpClient client, string message)
        {
            //Encodes and sends message
            byte[] Buffer;
            Buffer = Encoding.Default.GetBytes(message);
            client.GetStream().Write(Buffer, 0, Buffer.Length);

            Console.WriteLine(message);

            //Closes connection
            client.Close();
        }

        static void Main(string[] args)
        {
            ServerMain svc = new ServerMain(); //Create a new object of the server class
            svc.Start(); //Start the server
        }
    }
}
