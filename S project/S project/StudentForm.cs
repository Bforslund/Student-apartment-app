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
        private UserInfo student;
        private MandatoryRules rules;
        private ServerConnection server;

        //Initialize forms for Complaints and Rules
        AddComplainStudent complaintForm = null;
        AddRuleStudent ruleForm = null;
        List<Schedule> schedules = new List<Schedule>();
        HouseRules houseRules = new HouseRules();

        private void AddMandatoryRule(MandatoryRuleServer rule)
        {
            // creating new labels
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            ruleNumber.Text = (rule.ID + 1).ToString();

            AddMandatoryRuleRow(ruleNumber, ruleLabel);
        }
        public void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;
            // when you click it hides everything.


            pnlMandatoryRules.RowCount = newRow; // creates a new row
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow); // Add the rulenumber label to coloum 0, and on the new row
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);

            pnlMandatoryRules.Update(); // update the screen, method already exists
        }
        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        public StudentForm(ServerConnection server, UserInfo student)
        {
            InitializeComponent();

            this.student = student;
            this.server = server;
            lblHello.Text = "Hello, " + this.student.Name;
            rules = server.GetMandatoryRules(student.HouseNumber);
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
            if (AddRuleStudent.ruleName != "")
            {
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
            if (ruleForm != null)
            {
                if (ruleForm.IsDisposed == true)
                {
                    ruleForm = null;
                }
            }

            //If the complaint Form has been closed, revert complaintForm back to null
            if (complaintForm != null)
            {
                if (complaintForm.IsDisposed == true)
                {
                    complaintForm = null;
                }
            }
        }

        //Update the rules lists every second
        private void TimerRules_Tick(object sender, EventArgs e)
        {
            if (rules.AllRules.Count != pnlMandatoryRules.Controls.Count)
            {
                pnlMandatoryRules.Controls.Clear();

                foreach (MandatoryRuleServer rule in rules.AllRules)
                {
                    AddMandatoryRule(rule);
                }
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            

            for (int i = 0; i < houseRules.AllRules.Count; i++)
            {
                Schedule currentScheduleItem = new Schedule(student, i);
                if (currentScheduleItem.GetID() == student.ID)
                {
                    
                    schedules.Add(currentScheduleItem);
                    
                }
            }

            SortArray();

            for (int i = 0; i < schedules.Count; i++ )
            {
                schedules[i].Location = new System.Drawing.Point(10, tableLayoutPanel4.Top - schedules.Count * 100);
                schedules[i].Name = "Task";
                schedules[i].Size = new System.Drawing.Size(tableLayoutPanel4.Width - 10, 100);
                schedules[i].TabIndex = 0;
            }
        }
        private void SortArray()
        {
            Schedule temp;

            for (int j = 0; j <= schedules.Count - 2; j++)
            {
                for (int i = 0; i <= schedules.Count - 2; i++)
                {
                    if (schedules[i].GetDays() > schedules[i + 1].GetDays())
                    {
                        temp = schedules[i + 1];
                        schedules[i + 1] = schedules[i];
                        schedules[i] = temp;
                    }
                }
            }

        }
    }
}
