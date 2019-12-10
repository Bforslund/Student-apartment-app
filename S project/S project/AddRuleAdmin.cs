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
       
        private AdminForm admina;

        public AddRuleAdmin(AdminForm admin)
        {
            admina = admin;
            InitializeComponent();
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            if(tbxRuleName.Text != "")
            {
                //Get the text from the textbox for the StudentForm
               MandatoryRule Rule1 = new MandatoryRule();
                Rule1.rule = tbxRuleName.Text;
                tbxRuleName.Clear();
                admina.AddMandatoryRule(Rule1);
                Dispose();
            }
            else
            {
                MessageBox.Show("Please enter a valid rule");
            }
        }
    }
}
