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
        public static string ruleName = "";
        public AddRuleAdmin()
        {
            InitializeComponent();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if(tbxRuleName.Text != "")
            {
                //Get the text from the textbox for the StudentForm
                ruleName = tbxRuleName.Text;
                tbxRuleName.Clear();
                Dispose();
            }
            else
            {
                MessageBox.Show("Please enter a valid rule");
            }
        }
    }
}
