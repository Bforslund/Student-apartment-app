using System;
using System.Collections.Generic;

namespace Server
{
    //Types of packages 
    public enum PackageType
    {
        USER_CHECK, INVALID_DATA, USER_INFO,
        GET_HOUSE_RULES, HOUSE_RULES, UPDATE_HOUSE_RULES,
        GET_MANDATORY_RULES, MANDATORY_RULES, UPDATE_MANDATORY_RULES,
        RECEIVED
    }

    //Types of user 
    public enum UserType
    {
        TENANT, EMPLOYEE
    }

    //Package sent through TCP connection 
    //(Message can be a Serialise JSON/an empty string/)
    class ServerPackage
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
    class UserCheck
    {
        public int HouseNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    //User info sent by the server (login & password are omited)
    class UserInfo
    {
        public UserType Type { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int HouseNumber { get; set; }
        public int Room { get; set; }
        public int TotalStudentNumber { get; set; }
    }

    //Info about user stored on the server
    class ServerUser
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public UserType Type { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int HouseNumber { get; set; }
        public int Room { get; set; }
    }

    class Users
    {
        public int TotalStudentNumber { get; set; }
        public List<ServerUser> AllUsers { get; set; }
    }

    //Rules set by the company
    class MandatoryRule
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
    }

    class MandatoryRules
    {
        public int HouseNumber { get; set; }
        public List<MandatoryRule> AllRules { get; set; }
    }

    //Rules set by tenant
    class HouseRule
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
        public List<int> OrderOfStudents { get; set; }
        public int CurrentStudent { get; set; }
        public DateTime LastCompleted { get; set; }
        public int Interval { get; set; }
        public bool OnlyThisWeek { get; set; }
        public Dictionary<string, bool> StudentsApproval { get; set; }
        public bool ApprovalState { get; set; }
    }

    class HouseRules
    {
        public int HouseNumber { get; set; }
        public List<HouseRule> AllRules { get; set; }
    }
}
