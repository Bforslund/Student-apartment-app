using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_project
{
    public partial class Schedule : UserControl
    {
        ScheduleItem scheduleItem;
        
        // Constructor To Bind the backend part to the UserControl
        public Schedule(UserInfo user, int index, HouseRules houseRules)
        {
            scheduleItem = new ScheduleItem(user, index, houseRules);
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        
        // Gets the days
        public int GetDays()
        {
            return scheduleItem.GetDays();
        }
        
        // Gets the ID of the student
        public int GetID()
        {
            return scheduleItem.GetID();
        }

        // Sets the correct days until and info of the assigned task
        private void Schedule_Load(object sender, EventArgs e)
        {
            label1.Text = scheduleItem.GetDays().ToString("D");
            label2.Text = scheduleItem.GetRuleInfo();
        }

        // Changes if the task is done or not
        private void DoneBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DoneBox.Checked)
            {
                scheduleItem.SetDone();
                this.BackColor = Color.LightGreen;

            } else
            {
                scheduleItem.SetUnDone();
                this.BackColor = Color.LightGray;
            }
        }
    }
}
