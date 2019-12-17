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
            // creates new labels
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

            // creates a new row
            pnlMandatoryRules.RowCount = newRow;
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow);
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);

            pnlMandatoryRules.Update(); // update the screen, method already exists
        }
        private void AddNotificationsRule(HouseRuleServer rule)
        {
            // creates labels and buttons to display
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();
            Button approve = new Button();
            approve.FlatStyle = FlatStyle.Flat;
            Button disapprove = new Button();
            disapprove.FlatStyle = FlatStyle.Flat;

            ruleLabel.Text = rule.RuleText + " every " + rule.Interval.ToString() + " days";
            ruleLabel.AutoSize = true;
            approve.Size = new Size(25, 25);
            approve.Text = "+";
            disapprove.Size = new Size(25, 25);
            disapprove.Text = "x";
            ruleNumber.Text = (rule.ID + 1).ToString();

            AddNotificationsRuleRow(ruleNumber, ruleLabel, approve, disapprove);
        }
        public void AddNotificationsRuleRow(Label ruleNumber, Label ruleLabel, Button approve, Button disapprove)
        {
            int newRow = pnlNotifications.RowCount + 1;

            //sets the buttons as enabled/disabled depending if the current student 
            //already approved this rule or not
            approve.Enabled = !houseRules.AllRules[Convert.ToInt32(ruleNumber.Text) - 1].StudentsApproval[student.ID];
            disapprove.Enabled = houseRules.AllRules[Convert.ToInt32(ruleNumber.Text) - 1].StudentsApproval[student.ID];
            if (!approve.Enabled)
            {
                approve.BackColor = Color.FromArgb(210, 210, 210);
            }
            else
            {
                approve.BackColor = Color.White;
            }
            if (!disapprove.Enabled)
            {
                disapprove.BackColor = Color.FromArgb(210, 210, 210);
            }
            else
            {
                disapprove.BackColor = Color.White;
            }
            //clicking the approve button disables it and changing the approval of the 
            //current student
            approve.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                approve.Enabled = false;
                approve.BackColor = Color.FromArgb(210, 210, 210);
                disapprove.Enabled = true;
                disapprove.BackColor = Color.White;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = true;

                server.UpdateHouseRules(houseRules);
            });
            //clicking the disapprove button disables it and changing the approval of the 
            //current student
            disapprove.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                disapprove.Enabled = false;
                disapprove.BackColor = Color.FromArgb(210, 210, 210);
                approve.Enabled = true;
                approve.BackColor = Color.White;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = false;

                server.UpdateHouseRules(houseRules);
            });

            // creates a new row
            pnlNotifications.RowCount = newRow;
            pnlNotifications.Controls.Add(ruleNumber, 0, newRow);
            pnlNotifications.Controls.Add(ruleLabel, 1, newRow);
            pnlNotifications.Controls.Add(approve, 2, newRow);
            pnlNotifications.Controls.Add(disapprove, 3, newRow);

            pnlNotifications.Update(); // update the screen, method already exists
        }
        private void AddHouseRule(HouseRuleServer rule)
        {
            // creates new labels and button
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();
            Button disapprove = new Button();
            disapprove.FlatStyle = FlatStyle.Flat;

            if (rule.Interval == 1)
            {
                ruleLabel.Text = rule.RuleText + " everyday";
            }
            else
            {
                ruleLabel.Text = rule.RuleText + " every " + rule.Interval.ToString() + " days";
            }
            ruleLabel.AutoSize = true;
            disapprove.Size = new Size(25, 25);
            disapprove.Text = "x";
            ruleNumber.Text = (rule.ID + 1).ToString();

            AddHouseRuleRow(ruleNumber, ruleLabel, disapprove);
        }
        public void AddHouseRuleRow(Label ruleNumber, Label ruleLabel, Button disapprove)
        {
            int newRow = pnlHouseRules.RowCount + 1;

            disapprove.Enabled = houseRules.AllRules[Convert.ToInt32(ruleNumber.Text) - 1].StudentsApproval[student.ID];
            if (!disapprove.Enabled)
            {
                disapprove.BackColor = Color.FromArgb(210, 210, 210);
            }
            else
            {
                disapprove.BackColor = Color.White;
            }
            //clicking the disapprove button disables it and changing the approval of the 
            //current student
            disapprove.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;


                disapprove.Enabled = false;
                disapprove.BackColor = Color.FromArgb(210, 210, 210);
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = false;

                server.UpdateHouseRules(houseRules);
            });

            // creates a new row
            pnlHouseRules.RowCount = newRow;
            pnlHouseRules.Controls.Add(ruleNumber, 0, newRow);
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

                for (int i = 0; i < student.TotalStudentNumber; i++)
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

            if (houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4)
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

            for (int i = 0; i < houseRules.AllRules.Count; i++)
            {
                int numberOfApprovals = 0;

                for (int j = 0; j < student.TotalStudentNumber; j++)
                {
                    numberOfApprovals += Convert.ToInt32(houseRules.AllRules[i].StudentsApproval[j + 1]);
                }

                if (numberOfApprovals > student.TotalStudentNumber / 2)
                {
                    if (houseRules.AllRules[i].ApprovalState == false)
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

            for (int i = 0; i < schedules.Count; i++)
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