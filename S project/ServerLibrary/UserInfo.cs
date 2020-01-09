using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    //User info sent by the server (login & password are omited)
    public class UserInfo
    {
        public UserType Type { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public int Room { get; set; }
        public int TotalStudentNumber { get; set; }
        public Dictionary<int, string> StudentsInfo { get; set; }
    }
}
