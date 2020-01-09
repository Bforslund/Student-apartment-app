using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    public class UserCheck
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int HouseNumber { get; set; }

        public UserCheck(string login, string password, int houseNumber)
        {
            this.Login = login;
            this.Password = password;
            this.HouseNumber = houseNumber;
        }
    }
}
