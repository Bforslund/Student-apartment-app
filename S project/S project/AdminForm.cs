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
               // lbxMandatoryRules.Items.Add(Login.mandatoryRules[Login.mandatoryRules.Count - 1].GetName());
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
            
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            // i have a button click to update now, but I want to update my list whenever a rule is sent. So When that is Done i will adjust this.
            // create a method or a list from the student form.
            Button removeRuleButton = new Button();
            Label rule = new Label();
            Label ruleNumber = new Label();
            rule.Text = "House rule";
            removeRuleButton.Size = new Size(98, 33);
            removeRuleButton.Text = "Remove";

            int newRow = houseRulesPane.RowCount + 1;
            ruleNumber.Text = houseRulesPane.RowCount.ToString();
            removeRuleButton.Click += new EventHandler((s, ea) => { ruleNumber.Hide(); rule.Hide(); removeRuleButton.Hide(); });
            houseRulesPane.RowCount = newRow;
            houseRulesPane.Controls.Add(ruleNumber, 0, newRow);
            houseRulesPane.Controls.Add(rule, 1, newRow);
            houseRulesPane.Controls.Add(removeRuleButton, 2, newRow);
            houseRulesPane.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button removeRuleButton = new Button();
            Label rule = new Label();
            Label ruleNumber = new Label();
            rule.Text = "Admin rule";
            removeRuleButton.Size = new Size(98, 33);
            removeRuleButton.Text = "Remove";

            int newRow = mandatoryRulesPane.RowCount + 1;
            ruleNumber.Text = mandatoryRulesPane.RowCount.ToString();
            removeRuleButton.Click += new EventHandler((s, ea) => { ruleNumber.Hide(); rule.Hide(); removeRuleButton.Hide(); });
            mandatoryRulesPane.RowCount = newRow;
            mandatoryRulesPane.Controls.Add(ruleNumber, 0, newRow);
            mandatoryRulesPane.Controls.Add(rule, 1, newRow);
            mandatoryRulesPane.Controls.Add(removeRuleButton, 2, newRow);
            mandatoryRulesPane.Update();
        }
    }
}
