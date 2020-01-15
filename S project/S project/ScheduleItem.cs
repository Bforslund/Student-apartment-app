﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerLibrary;

namespace S_project
{
    class ScheduleItem
    {
        private DateTime dateTimeBuffer;
        private String name;
        private int ID;
        private int index;
        TimeSpan span;

        HouseRules houseRules;
        ServerConnection serverConnection = new ServerConnection();

        // Constructor that sets some info on the object correct in the instance variables
        public ScheduleItem(UserInfo user, int index, HouseRules houseRules)
        {
            this.houseRules = houseRules;
            this.index = index;
            int timesUntilNextAppointment = 0;
            for( int i = 1; i <= houseRules.AllRules[index].OrderOfStudents.Count; i++ )
            {
                int p = houseRules.AllRules[index].CurrentStudent;
                if (user.ID == houseRules.AllRules[index].CurrentStudent)
                {
                    timesUntilNextAppointment = i;
                    break;
                }
                p++;
                if (p == houseRules.AllRules[index].OrderOfStudents.Count)
                {
                    p = 0;
                }
            }
            this.ID = houseRules.AllRules[this.index].OrderOfStudents[houseRules.AllRules[this.index].CurrentStudent];
            span = DateTime.Today.Subtract(houseRules.AllRules[index].LastCompleted.AddDays(timesUntilNextAppointment*houseRules.AllRules[index].Interval));
        }
        
        // Gets the Schedule Item info
        public String GetRuleInfo()
        {
            return houseRules.AllRules[index].RuleText;
        }
        
        // Gets the amount of days still left until the task needs to be done
        public int GetDays()
        {
            return span.Days;
        }

        // Returns the name of the person assigned to the task
        public int GetID()
        {
            return this.ID;
        }

        // Checks if the task is done today
        public bool GetDone()
        {

            if (span.Days < 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Sets the task as being done
        public void SetDone()
        {           
            dateTimeBuffer = houseRules.AllRules[index].LastCompleted;
            houseRules.AllRules[index].LastCompleted = DateTime.Today;
            houseRules.AllRules[index].CurrentStudent += 1;
            if ( houseRules.AllRules[index].CurrentStudent == houseRules.AllRules[index].OrderOfStudents.Count())
            {
                houseRules.AllRules[index].CurrentStudent = 0;
            }

            
            serverConnection.UpdateHouseRules(houseRules);
        }

        // Sets the task as being undone (for mistake purposes)
        public void SetUnDone()
        {
            houseRules.AllRules[index].LastCompleted = dateTimeBuffer;
            houseRules.AllRules[index].CurrentStudent -= 1;
            if (houseRules.AllRules[index].CurrentStudent < 0)
            {
                houseRules.AllRules[index].CurrentStudent = houseRules.AllRules[index].OrderOfStudents.Count() - 1;
            }
            //houseRules.AllRules[index].OrderOfStudents[houseRules.AllRules[index].CurrentStudent] = houseRules.AllRules[index].OrderOfStudents[houseRules.AllRules[index].CurrentStudent - 1];
            serverConnection.UpdateHouseRules(houseRules);
        }
    }
}
