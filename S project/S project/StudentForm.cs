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
    public partial class StudentForm : Form
    {
        private Student student;

        //Initialize forms for Complaints and Rules
        AddComplainStudent complaintForm = null;
        AddRuleStudent ruleForm = null;

        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        public StudentForm(Student student)
        {
            InitializeComponent();

            this.student = student;
            lblHello.Text = "Hello, " + this.student.GetFirstName() + " " + this.student.GetLastName();
        }

        private void PctbxBack_Click(object sender, EventArgs e)
        {
            GoBackToLogin();
        }

        private void BtnComplain_Click(object sender, EventArgs e)
        {
            //If a Complaint Form does not already exist, create one
            if (complaintForm == null)
            {
                complaintForm = new AddComplainStudent();
                complaintForm.Show();
            }
        }

        private void BtnProposeRule_Click(object sender, EventArgs e)
        {
            //If a Rule Form does not already exist, create one
            if (ruleForm == null)
            {
                ruleForm = new AddRuleStudent();
                ruleForm.Show();
            }
        }

        private void TimerUpdates_Tick(object sender, EventArgs e)
        {
            //If a rule has been added to the textbox in the Rule Form and 
            //the Add button has been pressed, get the rule from that textbox
            if(AddRuleStudent.ruleName != "")
            {
                Login.studentRules.Add(new StudentRule(AddRuleStudent.ruleName, AddRuleStudent.repeatRule, student.GetHouseNumber()));
                lbxHouseRules.Items.Add(Login.studentRules[Login.studentRules.Count - 1].GetName() + " every " + Login.studentRules[Login.studentRules.Count - 1].GetRepeating() + " days");
                AddRuleStudent.ruleName = "";
                AddRuleStudent.repeatRule = 0;
            }

            //If a complaint has been filed to the textbox in the Complaint Form and 
            //the Add button has been pressed, get the complaint from that textbox
            if (AddComplainStudent.ruleBroken != "")
            {
                AddComplainStudent.ruleBroken = "";
                AddComplainStudent.nameOfRuleBreaker = "";
            }

            //If the rule form has been closed, revert ruleForm back to null
            if(ruleForm != null)
            {
                if(ruleForm.IsDisposed == true)
                {
                    ruleForm = null;
                }
            }

            //If the complaint Form has been closed, revert complaintForm back to null
            if(complaintForm != null)
            {
                if(complaintForm.IsDisposed == true)
                {
                    complaintForm = null;
                }
            }
        }

        //Update the rules lists every second
        private void TimerRules_Tick(object sender, EventArgs e)
        {
            lbxHouseRules.Items.Clear();
            for (int i = 0; i < Login.studentRules.Count; i++)
            {
                if (Login.studentRules[i].GetHouseNumber() == student.GetHouseNumber())
                {
                    lbxHouseRules.Items.Add(Login.studentRules[i].GetName() + " every " + Login.studentRules[i].GetRepeating() + " days");
                }
            }

            lbxMandatoryRules.Items.Clear();
            for (int i = 0; i < Login.mandatoryRules.Count; i++)
            {
                lbxMandatoryRules.Items.Add(Login.mandatoryRules[i].GetName());
            }
        }
    }
}
