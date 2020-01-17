using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerLibrary;

namespace S_project
{
    public partial class AddComplainStudent : Form
    {
        public static string ruleBroken = "";
        public static int IDOfRuleBreaker = 0;
        public static int IDOfComplainer = 0;
        private StudentForm parent;
        private HouseRules houseRules;
        private MandatoryRules mandatoryRules;
        private UserInfo user;
        private List<int> IDs = new List<int>();

        public AddComplainStudent(HouseRules houseRules, MandatoryRules mandatoryRules, UserInfo user, Form form)
        {
            InitializeComponent();

            this.parent = (StudentForm)form;
            this.houseRules = houseRules;
            this.mandatoryRules = mandatoryRules;
            this.user = user;
            cbAnon.Checked = false;
        }

        private void BtnAddComplaint_Click(object sender, EventArgs e)
        {
            if(cbxRuleBroken.SelectedItem != null)
            {
                if(cbxName.SelectedItem != null)
                {
                    //Get the complaint from the textbox for the StudentForm
                    ruleBroken = cbxRuleBroken.Text;
                    IDOfRuleBreaker = IDs.ElementAt(cbxName.SelectedIndex);

                    if (cbAnon.Checked == false)
                    {
                        IDOfComplainer = user.ID;
                    }
                    else
                    {
                        IDOfComplainer = -1;
                    }
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Please select a name");
                }
            }
            else
            {
                MessageBox.Show("Please select the broken rule");
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            int approvedRules = 0;

            foreach (var rule in parent.houseRules.AllRules)
            {
                if (rule.ApprovalState == true)
                {
                    approvedRules++;
                }
            }

            if (cbxRuleBroken.Items.Count != parent.mandatoryRules.AllRules.Count + approvedRules)
            {
                cbxRuleBroken.Items.Clear();

                foreach (var rule in parent.mandatoryRules.AllRules)
                {
                    cbxRuleBroken.Items.Add(rule.RuleText);
                }
                foreach (var rule in parent.houseRules.AllRules)
                {
                    if (rule.ApprovalState == true)
                    {
                        cbxRuleBroken.Items.Add(rule.RuleText);
                    }
                }
            }

            if (cbxName.Items.Count != this.user.StudentsInfo.Count - 1)
            {
                cbxName.Items.Clear();

                foreach (var student in this.user.StudentsInfo)            
                {
                    if (user.ID > 0 && user.ID != student.Key)
                    {
                        cbxName.Items.Add(student.Value);
                        IDs.Add(student.Key);
                    }
                }

                cbxName.Items[0] = "Unknown";
                IDs[0] = -1;
            }
        }
    }
}
