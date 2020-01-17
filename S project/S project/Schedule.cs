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
        private bool change = false;
        // Constructor To Bind the backend part to the UserControl
        public Schedule(UserInfo user, int index, HouseRules houseRules, Form parent)
        {
            InitializeComponent();

            this.parent = (StudentForm)parent;
            scheduleItem = new ScheduleItem(user, index, houseRules);

            change = false;

            if (houseRules.AllRules[index].LastCompleted == DateTime.Today && user.ID != houseRules.AllRules[index].CurrentStudentId)
            {
                DoneBox.Enabled = true;
                DoneBox.Checked = true;
                this.BackColor = Color.LightGreen;
            }
            else if (GetDays() == 0)
            {
                DoneBox.Enabled = true;
                DoneBox.Checked = false;
                this.BackColor = Color.LightBlue;
            }
            else
            {
                DoneBox.Enabled = false;
                DoneBox.Checked = false;
                this.BackColor = Color.LightGray;
            }

            change = true;
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
            int waitDays = scheduleItem.GetDays();

            switch (waitDays)
            {
                case 0:
                    label1.Text = "Today";
                    break;
                case 1:
                    label1.Text = "Tomorrow";
                    break;
                default:
                    label1.Text = $"In {waitDays} Days";
                    break;
            }

            label2.Text = scheduleItem.GetRuleInfo();
        }

        // Changes if the task is done or not
        private void DoneBox_CheckedChanged(object sender, EventArgs e)
        {
            if (change)
            {
                if (DoneBox.Checked)
                {
                    scheduleItem.SetDone(parent.houseRules);
                    this.BackColor = Color.LightGreen;
                }
                else
                {
                    scheduleItem.SetUnDone(parent.houseRules);
                    this.BackColor = Color.LightBlue;
                }
            }
        }

        public void DisableDoneBox()
        {
            DoneBox.Enabled = false;
        }
    }
}
