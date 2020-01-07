using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_project
{
    public partial class AddComplainStudent : Form
    {
        public static string ruleBroken = "";
        public static int IDOfRuleBreaker = 0;
        public static int IDOfComplainer = 0;
        HouseRules houseRules;
        MandatoryRules mandatoryRules;
        UserInfo users;
        List<int> IDs = new List<int>();
        public AddComplainStudent(HouseRules houseRules, MandatoryRules mandatoryRules, UserInfo users)
        {
            InitializeComponent();
            this.houseRules = houseRules;
            this.mandatoryRules = mandatoryRules;
            this.users = users;
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
                        IDOfComplainer = users.ID;
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
            if (cbxRuleBroken.Items.Count != this.mandatoryRules.AllRules.Count + this.houseRules.AllRules.Count)
            {
                foreach (var rule in this.mandatoryRules.AllRules)
                {
                    cbxRuleBroken.Items.Add(rule.RuleText);
                }
                foreach (var rule in this.houseRules.AllRules)
                {
                    cbxRuleBroken.Items.Add(rule.RuleText);
                }
            }

            if (cbxName.Items.Count != this.users.StudentsInfo.Count - 1)
            {
                foreach (var student in this.users.StudentsInfo)
                {
                    if (users.Name != student.Value)
                    {
                        cbxName.Items.Add(student.Value);
                        IDs.Add(student.Key);
                    }
                }
                cbxName.Items[0] = "Unkown";
                IDs[0] = -1;
            }
        }
    }
}
