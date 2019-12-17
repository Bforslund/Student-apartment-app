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
        private MandatoryRules mandatoryRules;
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
        private void AddNotificationsRule(HouseRuleServer rule)
        {
            // creating new labels
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();
            Button approve = new Button();
            Button disapprove = new Button();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            approve.Size = new Size(30, 25);
            approve.Text = "+";
            disapprove.Size = new Size(30, 25);
            disapprove.Text = "x";
            ruleNumber.Text = (rule.ID + 1).ToString();

            AddNotificationsRuleRow(ruleNumber, ruleLabel, approve, disapprove);
        }
        public void AddNotificationsRuleRow(Label ruleNumber, Label ruleLabel, Button approve, Button disapprove)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;
            // when you click it hides everything.

            approve.Enabled = !houseRules.AllRules[Convert.ToInt32(ruleNumber.Text) - 1].StudentsApproval[student.ID];
            disapprove.Enabled = houseRules.AllRules[Convert.ToInt32(ruleNumber.Text) - 1].StudentsApproval[student.ID];

            approve.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                approve.Enabled = false;
                disapprove.Enabled = true;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = true;

                server.UpdateHouseRules(houseRules);
            });

            disapprove.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                disapprove.Enabled = false;
                approve.Enabled = true;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = false;

                server.UpdateHouseRules(houseRules);
            });

            pnlNotifications.RowCount = newRow; // creates a new row
            pnlNotifications.Controls.Add(ruleNumber, 0, newRow); // Add the rulenumber label to coloum 0, and on the new row
            pnlNotifications.Controls.Add(ruleLabel, 1, newRow);
            pnlNotifications.Controls.Add(approve, 2, newRow);
            pnlNotifications.Controls.Add(disapprove, 3, newRow);

            pnlNotifications.Update(); // update the screen, method already exists
        }
        private void AddHouseRule(HouseRuleServer rule)
        {
            // creating new labels
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();
            Button disapprove = new Button();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            disapprove.Size = new Size(30, 25);
            disapprove.Text = "x";
            ruleNumber.Text = (rule.ID + 1).ToString();

            AddHouseRuleRow(ruleNumber, ruleLabel, disapprove);
        }
        public void AddHouseRuleRow(Label ruleNumber, Label ruleLabel, Button disapprove)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;
            // when you click it hides everything.

            disapprove.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                
                disapprove.Enabled = false;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = false;

                server.UpdateHouseRules(houseRules);
            });

            pnlHouseRules.RowCount = newRow; // creates a new row
            pnlHouseRules.Controls.Add(ruleNumber, 0, newRow); // Add the rulenumber label to coloum 0, and on the new row
            pnlHouseRules.Controls.Add(ruleLabel, 1, newRow);
            pnlHouseRules.Controls.Add(disapprove, 3, newRow);

            pnlHouseRules.Update(); // update the screen, method already exists
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
            mandatoryRules = server.GetMandatoryRules(student.HouseNumber);
            houseRules = server.GetHouseRules(student.HouseNumber);
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
                HouseRuleServer houseRule = new HouseRuleServer();
                houseRule.ApprovalState = false;
                houseRule.ID = houseRules.AllRules.Count;
                houseRule.Interval = AddRuleStudent.repeatRule;
                houseRule.RuleText = AddRuleStudent.ruleName;
                houseRule.LastCompleted = DateTime.Now;
                houseRule.OnlyThisWeek = false;

                for(int i = 0; i < student.TotalStudentNumber; i++)
                {
                    houseRule.StudentsApproval.Add(i + 1, false);

                    //The order of students is kept sorted by their ID
                    houseRule.OrderOfStudents.Add(i + 1);
                }

                houseRule.StudentsApproval[student.ID] = true;
                houseRules.AllRules.Add(houseRule);
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
            if (mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count / 2)
            {
                pnlMandatoryRules.Controls.Clear();

                foreach (MandatoryRuleServer rule in mandatoryRules.AllRules)
                {
                    AddMandatoryRule(rule);
                }
            }

            if(houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4)
            {
                pnlNotifications.Controls.Clear();
                pnlHouseRules.Controls.Clear();
                foreach (HouseRuleServer rule in houseRules.AllRules)
                {
                    if (rule.ApprovalState == false)
                    {
                        AddNotificationsRule(rule);
                    }
                    else
                    {
                        AddHouseRule(rule);
                    }
                }
            }

            for(int i = 0; i < houseRules.AllRules.Count; i++)
            {
                int numberOfApprovals = 0;

                for(int j = 0; j < student.TotalStudentNumber; j++)
                {
                    numberOfApprovals += Convert.ToInt32(houseRules.AllRules[i].StudentsApproval[j + 1]);
                }

                if(numberOfApprovals > student.TotalStudentNumber / 2)
                {
                    if(houseRules.AllRules[i].ApprovalState == false)
                    {
                        houseRules.AllRules[i].ApprovalState = true;
                        pnlNotifications.Controls.Clear();
                        pnlHouseRules.Controls.Clear();
                        foreach (HouseRuleServer rule in houseRules.AllRules)
                        {
                            if (rule.ApprovalState == false)
                            {
                                AddNotificationsRule(rule);
                            }
                            else
                            {
                                AddHouseRule(rule);
                            }
                        }
                    }
                }
                else
                {
                    if (houseRules.AllRules[i].ApprovalState == true)
                    {
                        houseRules.AllRules[i].ApprovalState = false;
                        pnlNotifications.Controls.Clear();
                        pnlHouseRules.Controls.Clear();
                        foreach (HouseRuleServer rule in houseRules.AllRules)
                        {
                            if (rule.ApprovalState == false)
                            {
                                AddNotificationsRule(rule);
                            }
                            else
                            {
                                AddHouseRule(rule);
                            }
                        }
                    }
                }
            }
        }
        
        // Method for drawing the required amount of UserControls
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            houseRules = server.GetHouseRules(student.HouseNumber);

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
        
        // Method for sorting the list of UserControls
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
