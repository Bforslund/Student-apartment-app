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
        public Schedule(UserInfo user, int index)
        {
            scheduleItem = new ScheduleItem(user, index);
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }

        

        public int GetDays()
        {
            return scheduleItem.GetDays();
        }

        public int GetID()
        {
            return scheduleItem.GetID();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            label1.Text = scheduleItem.GetDays().ToString("D");
            label2.Text = scheduleItem.GetRuleInfo();
        }

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
