using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    //Info about user stored on the server
    public class ServerUser
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public UserType Type { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public int Room { get; set; }

        public ServerUser(UserType type, string login, string password, string name, string lastName, int houseNumber, int room)
        {
            this.Type = type;
            this.ID = -1;
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.LastName = lastName;
            this.HouseNumber = houseNumber;
            this.Room = room;
        }
    }

    public class Users
    {
        public int TotalStudentNumber { get; set; }
        public List<ServerUser> AllUsers { get; set; }
    }
}
