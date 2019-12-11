using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_project
{
    class ScheduleItem
    {
        private DateTime dateTime;
        private String name;
        private bool done;
        
        public ScheduleItem()
        {

        }

        public DateTime GetDateTime()
        {
            return this.dateTime;
        }

        public String GetName()
        {
            return this.name;
        }

        public bool GetDone()
        {
            return done;
        }

        public void SetDone(bool done)
        {
            this.done = done;
        }


    }
}
