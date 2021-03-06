﻿using System;

namespace ServerLibrary
{
    //Types of packeges
    public enum PackageType
    {
        USER_CHECK, INVALID_DATA, USER_INFO, 
        GET_ALL_USERS, ALL_USERS,
        GET_HOUSE_RULES, HOUSE_RULES, UPDATE_HOUSE_RULES,
        GET_MANDATORY_RULES, MANDATORY_RULES, UPDATE_MANDATORY_RULES,
        GET_COMPLAINTS, COMPLAINTS, UPDATE_COMPLAINTS,
        GET_MESSAGES, MESSAGES, UPDATE_MESSAGES, 
        UPDATE_PASSWORD, PASSWORD_CHANGED,
        CREATE_NEW_USER, USER_CREATED, USER_EXISTS,
        RECEIVED
    }

    //Types of user 
    public enum UserType
    {
        TENANT, EMPLOYEE
    }
}
