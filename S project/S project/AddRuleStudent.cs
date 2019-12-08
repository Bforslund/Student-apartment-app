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
    public partial class AddRuleStudent : Form
    {
        public static string ruleName = "";
        public static int repeatRule = 0;
        public AddRuleStudent()
        {
            InitializeComponent();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if (tbxRuleName.Text != "")
            {
                if (numericRepeatRule.Value != 0)
                {
                    //Get the text from the textbox for the StudentForm
                    ruleName = tbxRuleName.Text;
                    tbxRuleName.Clear();
                    repeatRule = Convert.ToInt32(numericRepeatRule.Value);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Please select how often the rule should repeat");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid rule");
            }
        }
    }
}
