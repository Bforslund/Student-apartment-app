using System;
using System.Collections.Generic;

namespace Server
{
    //Package sent through TCP connection 
    //(Message can be a Serialise JSON/an empty string/)
    public class ServerPackage
    {
        public PackageType Type { get; set; }
        public string Message { get; set; }

        public ServerPackage(PackageType type, string msg)
        {
            Type = type;
            Message = msg;
        }
    }

    //Used for log in 
    public class UserCheck
    {
        public int HouseNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

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
    }

    public class Users
    {
        public int TotalStudentNumber { get; set; }
        public List<ServerUser> AllUsers { get; set; }
    }

    //Rules set by the company
    public class MandatoryRule
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
    }

    public class MandatoryRules
    {
        public int HouseNumber { get; set; }
        public List<MandatoryRule> AllRules { get; set; }
    }

    //Rules set by tenant
    public class HouseRule
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
        public List<int> OrderOfStudents { get; set; }
        public int CurrentStudent { get; set; }
        public DateTime LastCompleted { get; set; }
        public int Interval { get; set; }
        public bool OnlyThisWeek { get; set; }
        public Dictionary<int, bool> StudentsApproval { get; set; }
        public bool ApprovalState { get; set; }
    }

    public class HouseRules
    {
        public int HouseNumber { get; set; }
        public List<HouseRule> AllRules { get; set; }
    }

    //Complaints sent by the students
    public class Complaint
    {
        public int ID { get; set; }
        public string ComplaintText { get; set; }
        public DateTime FiledDate { get; set; }
        public int FiledBy { get; set; } //person's ID
        public int BrokenBy { get; set; } //person's ID
    }

    public class Complaints
    {
        public int HouseNumber { get; set; }
        public List<Complaint> AllComplaints { get; set; }
    }
}
