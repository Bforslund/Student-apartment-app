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
        public static string nameOfRuleBreaker = "";
        public AddComplainStudent()
        {
            InitializeComponent();
        }

        private void BtnAddComplaint_Click(object sender, EventArgs e)
        {
            if(cbxRuleBroken.SelectedItem != null)
            {
                if(cbxName.SelectedItem != null)
                {
                    //Get the complaint from the textbox for the StudentForm
                    ruleBroken = cbxRuleBroken.Text;
                    nameOfRuleBreaker = cbxName.Text;
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
    }
}
