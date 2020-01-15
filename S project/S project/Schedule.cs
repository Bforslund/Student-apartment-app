using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerLibrary;

namespace S_project
{
    public partial class Schedule : UserControl
    {
        private ScheduleItem scheduleItem;
        private StudentForm parent;

        // Constructor To Bind the backend part to the UserControl
        public Schedule(UserInfo user, int index, HouseRules houseRules, Form parent)
        {
            this.parent = (StudentForm)parent;
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
            this.Width = this.Parent.Width;
            label1.Text = "In " + scheduleItem.GetDays().ToString("D") + " Days";
            label2.Text = scheduleItem.GetRuleInfo();
        }

        // Changes if the task is done or not
        private void DoneBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DoneBox.Checked)
            {
                scheduleItem.SetDone();
                this.BackColor = Color.LightGreen;
            } 
            else
            {
                scheduleItem.SetUnDone();
                this.BackColor = Color.LightGray;
            }

            parent.ScheduleUpdate();
        }

        public void DisableDoneBox()
        {
            DoneBox.Enabled = false;
        }
    }
}
