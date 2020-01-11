using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    //Package sent through TCP connection 
    //(Message can be a Serialise JSON/an empty string/)
    public class ServerPackage
    {
        public PackageType Type { get; set; }
        public string Message { get; set; }
        public int UdpServerPort { get; set; }

        public ServerPackage(PackageType type, string msg, int udpServerPort)
        {
            this.Type = type;
            this.Message = msg;
            this.UdpServerPort = udpServerPort;
        }
    }
}
