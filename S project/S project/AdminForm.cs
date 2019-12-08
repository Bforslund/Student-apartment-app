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
    public partial class AdminForm : Form
    {
        AddRuleAdmin newRuleAdmin = null;

        int houseNumber;

        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
        public AdminForm(int houseNumber)
        {
            InitializeComponent();
            this.houseNumber = houseNumber;
        }

        private void PctbxBack_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            //If a Rule Form does not already exist, create one
            if (newRuleAdmin == null)
            {
                newRuleAdmin = new AddRuleAdmin();
                newRuleAdmin.Show();
            }
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            //If a rule has been added to the textbox in the Rule Form and 
            //the Add button has been pressed, get the rule from that textbox
            if (AddRuleAdmin.ruleName != "")
            {
                Login.mandatoryRules.Add(new MandatoryRule(AddRuleAdmin.ruleName));
                lbxMandatoryRules.Items.Add(Login.mandatoryRules[Login.mandatoryRules.Count - 1].GetName());
                AddRuleAdmin.ruleName = "";
            }

            //If the rule form has been closed, revert ruleForm back to null
            if (newRuleAdmin != null)
            {
                if(newRuleAdmin.IsDisposed == true)
                {
                    newRuleAdmin = null;
                }
            }
        }
        //Update the list every second
        private void TimerRules_Tick(object sender, EventArgs e)
        {
            lbxMandatoryRules.Items.Clear();
            for (int i = 0; i < Login.mandatoryRules.Count; i++)
            {
                lbxMandatoryRules.Items.Add(Login.mandatoryRules[i].GetName());
            }
        }
    }
}
