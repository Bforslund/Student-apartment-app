using System;
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
        private string name;
        private int ID;
        private int index;
        private TimeSpan span;

        private HouseRules houseRules;
        private HouseRule houseRule;
        private ServerConnection serverConnection = new ServerConnection();

        // Constructor that sets some info on the object correct in the instance variables
        public ScheduleItem(UserInfo user, int index, HouseRules houseRules)
        {
            this.houseRules = houseRules;
            this.houseRule = houseRules.AllRules[index];
            this.dateTimeBuffer = this.houseRule.LastCompleted;

            this.index = index;
            int timesUntilNextAppointment;

            if (houseRules.AllRules[index].LastCompleted == DateTime.Today && user.ID != houseRules.AllRules[index].CurrentStudentId)
            {
                timesUntilNextAppointment = 0;
            }
            else if (user.ID == houseRules.AllRules[index].CurrentStudentId)
            {
                timesUntilNextAppointment = 1;
            }
            else
            {
                int current = houseRule.CurrentStudentId;

                timesUntilNextAppointment = Math.Abs(user.ID - current);

                if (timesUntilNextAppointment < 0)
                    timesUntilNextAppointment += houseRule.OrderOfStudents.Count;

                timesUntilNextAppointment += 1;
            }

            this.ID = houseRule.CurrentStudentId;
            span = houseRule.LastCompleted.AddDays(timesUntilNextAppointment * houseRule.Interval).Subtract(DateTime.Today);
        }
        
        // Gets the Schedule Item info
        public string GetRuleInfo()
        {
            return houseRule.RuleText;
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
        public void SetDone(HouseRules hr)
        {           
            dateTimeBuffer = houseRule.LastCompleted;
            houseRule.LastCompleted = DateTime.Today;
            houseRule.CurrentStudentId += 1;

            if ( houseRule.CurrentStudentId > houseRule.OrderOfStudents.Count())
            {
                houseRule.CurrentStudentId = houseRule.OrderOfStudents[0];
            }

            hr.AllRules[index] = this.houseRule;
            serverConnection.UpdateHouseRules(hr);
        }

        // Sets the task as being undone (for mistake purposes)
        public void SetUnDone(HouseRules hr)
        {
            houseRule.LastCompleted = dateTimeBuffer.Subtract(TimeSpan.FromDays(houseRule.Interval));
            houseRule.CurrentStudentId -= 1;

            if (houseRule.CurrentStudentId < 1)
            {
                houseRule.CurrentStudentId = houseRule.OrderOfStudents.Count() - 1;
            }

            hr.AllRules[index] = this.houseRule;
            serverConnection.UpdateHouseRules(hr);
        }
    }
}
