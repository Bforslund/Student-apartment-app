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
    public partial class AddRuleAdmin : Form
    {
        private ServerConnection _server;
        private int _houseNumber;

        public AddRuleAdmin(ServerConnection server, int housenumber)
        {
            _server = server;
            _houseNumber = housenumber;
            InitializeComponent();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if(tbxRuleName.Text != "")
            {
                MandatoryRuleServer NewRule = new MandatoryRuleServer(); // create a new rule from the class

                MandatoryRules rules = _server.GetMandatoryRules(_houseNumber); // get existing rules from the server

                NewRule.RuleText = tbxRuleName.Text; // set the new ruleText from the textbox
                NewRule.ID = rules.AllRules.Count+1; // the Id is the count of the rules.

                rules.AllRules.Add(NewRule); // adding the new rule to the list 

                _server.UpdateMandatoryRules(rules); // update

                tbxRuleName.Clear();
                Dispose(); // close form
            }
            else
            {
                MessageBox.Show("Please enter a valid rule");
            }
        }
    }
}
