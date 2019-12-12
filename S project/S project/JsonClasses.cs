using System;
using System.Collections.Generic;

namespace S_project
{
    //Types of packages 
    public enum PackageType
    {
        USER_CHECK, INVALID_DATA, USER_INFO,
        GET_HOUSE_RULES, HOUSE_RULES, UPDATE_HOUSE_RULES,
        GET_MANDATORY_RULES, MANDATORY_RULES, UPDATE_MANDATORY_RULES,
        GET_COMPLAINTS, COMPLAINTS, UPDATE_COMPLAINTS,
        RECEIVED
    }

    //Types of user 
    public enum UserType
    {
        TENANT, EMPLOYEE
    }

    //Package sent through TCP connection 
    //(Message can be a Serialise JSON or a string)
    public class ServerPackage
    {
        public PackageType Type { get; set; }
        public string Message { get; set; }

        public ServerPackage(PackageType type, string msg)
        {
            this.Type = type;
            this.Message = msg;
        }
    }

    //Used for log in 
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

    //User info sent by the server
    public class UserInfo
    {
        public UserType Type { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int HouseNumber { get; set; }
        public int Room { get; set; }
        public int TotalStudentNumber { get; set; }
        public Dictionary<string, int> StudentsInfo { get; set; }
    }

    //Rules set by tenant
    public class HouseRuleServer
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
        public List<HouseRuleServer> AllRules { get; set; }
    }

    //Rules set by the company
    public class MandatoryRuleServer 
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
    }

    public class MandatoryRules 
    {
        public int HouseNumber { get; set; }
        public List<MandatoryRuleServer> AllRules { get; set; } 
    }

    //Complaints sent by the students
    public class Complaint
    {
        public int ID { get; set; }
        public string ComplaintText { get; set; }
        public DateTime FiledDate { get; set; }
        public int FiledBy { get; set; } //person's ID
        public int BrokenBy { get; set; }
    }

    public class Complaints
    {
        public int HouseNumber { get; set; }
        public List<Complaint> AllComplaints { get; set; }
    }
}
