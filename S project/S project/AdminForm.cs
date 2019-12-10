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
        private ServerConnection _server;
        private int _houseNumber;
        
        public AdminForm(ServerConnection server, int houseNumber)
        {
            _houseNumber = houseNumber;
            _server = server;

            InitializeComponent();
        }
        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void PctbxBack_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            new AddRuleAdmin(_server, _houseNumber).Show();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            //MandatoryRules rules = _server.GetMandatoryRules(_houseNumber);

            //pnlMandatoryRules.Controls.Clear();
            //pnlMandatoryRules.RowStyles.Clear();

            //foreach(MandatoryRuleServer rule in rules.AllRules)
            //{
            //    AddMandatoryRule(rule);
            //}
        }


        private void button1_Click(object sender, EventArgs e)
        {
       
            // i have a button click to update now, but I want to update my list whenever a rule is sent. So When that is Done i will adjust this.
          
            Button removeRuleButton = new Button();
            Label rule = new Label();
            Label ruleNumber = new Label();
            rule.Text = "House rule";
            removeRuleButton.Size = new Size(98, 33);
            removeRuleButton.Text = "Remove";

            int newRow = pnlHouseRules.RowCount + 1;
            ruleNumber.Text = pnlHouseRules.RowCount.ToString();
            removeRuleButton.Click += new EventHandler((s, ea) => { ruleNumber.Hide(); rule.Hide(); removeRuleButton.Hide(); });
            pnlHouseRules.RowCount = newRow;
            pnlHouseRules.Controls.Add(ruleNumber, 0, newRow);
            pnlHouseRules.Controls.Add(rule, 1, newRow);
            pnlHouseRules.Controls.Add(removeRuleButton, 2, newRow);
            pnlHouseRules.Update();
        }

        private void AddMandatoryRule(MandatoryRuleServer rule)
        {
           // creating new labels and buttons
            Button removeRuleButton = new Button(); 
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();
            
            ruleLabel.Text = rule.RuleText;
            removeRuleButton.Size = new Size(98, 33);
            removeRuleButton.Text = "Remove";
            ruleNumber.Text = rule.ID.ToString();

            AddMandatoryRuleRow(ruleNumber, ruleLabel, removeRuleButton);
         
        }

        private void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel, Button removeRuleButton)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;
            // when you click it hides everything.
            removeRuleButton.Click += new EventHandler((s, ea) => { ruleNumber.Hide(); ruleLabel.Hide(); removeRuleButton.Hide(); });
     
            pnlMandatoryRules.RowCount = newRow; // creates a new row
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow); // Add the rulenumber label to coloum 0, and on the new row
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);
            pnlMandatoryRules.Controls.Add(removeRuleButton, 2, newRow);
           
            pnlMandatoryRules.Update(); // update the screen, method already exists
        }
    }
}
