using System;

namespace ServerLibrary
{
    //Types of packeges
    public enum PackageType
    {
        USER_CHECK, INVALID_DATA, USER_INFO,
        GET_HOUSE_RULES, HOUSE_RULES, UPDATE_HOUSE_RULES,
        GET_MANDATORY_RULES, MANDATORY_RULES, UPDATE_MANDATORY_RULES,
        GET_COMPLAINTS, COMPLAINTS, UPDATE_COMPLAINTS,
        GET_MESSAGES,
        MESSAGES,
        UPDATE_MESSAGES,
        RECEIVED
    }

    //Types of user 
    public enum UserType
    {
        TENANT, EMPLOYEE
    }
}
