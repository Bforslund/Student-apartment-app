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
        private ChatHistory _messages;

        //Initialize forms for Complaints and Rules
        AddComplainStudent complaintForm = null;
        AddRuleStudent ruleForm = null;
        List<Schedule> schedules = new List<Schedule>();
        HouseRules houseRules = new HouseRules();
        Complaints complaints = new Complaints();


        public StudentForm(ServerConnection server, UserInfo student)
        {
            InitializeComponent();

            this.student = student;
            this.server = server;
            lblHello.Text = "Hello, " + this.student.Name;
            mandatoryRules = server.GetMandatoryRules(student.HouseNumber);
            houseRules = server.GetHouseRules(student.HouseNumber);
            complaints = server.GetComplaints(student.HouseNumber);
            _messages = server.GetMessages(student.HouseNumber);

            timerRules.Start();
            timerUpdate.Start();

            RulesUpdateTick(false);
            UpdatesTick();
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

        private void AddMandatoryRule(MandatoryRuleServer rule, int index)
        {
            // creates new labels
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            ruleNumber.Text = (index + 1).ToString();

            AddMandatoryRuleRow(ruleNumber, ruleLabel);
        }
        
        public void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;

            // creates a new row
            pnlMandatoryRules.RowCount = newRow;
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow);
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);

            //pnlMandatoryRules.Update(); // update the screen, method already exists
        }

        private void AddNotificationsRule(HouseRuleServer rule, int index , int textIndex)
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
            ruleNumber.Text = (textIndex + 1).ToString();
            ruleNumber.Tag = index + 1;

            AddNotificationsRuleRow(ruleNumber, ruleLabel, approve, disapprove);
        }

        public void AddNotificationsRuleRow(Label ruleNumber, Label ruleLabel, Button approve, Button disapprove)
        {
            int newRow = pnlNotifications.RowCount + 1;

            //sets the buttons as enabled/disabled depending if the current student 
            //already approved this rule or not
            approve.Enabled = !houseRules.AllRules[Convert.ToInt32(ruleNumber.Tag) - 1].StudentsApproval[student.ID];
            disapprove.Enabled = houseRules.AllRules[Convert.ToInt32(ruleNumber.Tag) - 1].StudentsApproval[student.ID];
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
                int index = Convert.ToInt32(ruleNumber.Tag) - 1;

                approve.Enabled = false;
                approve.BackColor = Color.FromArgb(210, 210, 210);
                disapprove.Enabled = true;
                disapprove.BackColor = Color.White;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = true;

                server.UpdateHouseRules(houseRules);
                RulesUpdateTick();
                UpdatesTick();
            });
            //clicking the disapprove button disables it and changing the approval of the 
            //current student
            disapprove.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Tag) - 1;

                disapprove.Enabled = false;
                disapprove.BackColor = Color.FromArgb(210, 210, 210);
                approve.Enabled = true;
                approve.BackColor = Color.White;
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = false;

                server.UpdateHouseRules(houseRules);
                RulesUpdateTick();
                UpdatesTick();
            });

            // creates a new row
            pnlNotifications.RowCount = newRow;
            pnlNotifications.Controls.Add(ruleNumber, 0, newRow);
            pnlNotifications.Controls.Add(ruleLabel, 1, newRow);
            pnlNotifications.Controls.Add(approve, 2, newRow);
            pnlNotifications.Controls.Add(disapprove, 3, newRow);

            //pnlNotifications.Update(); // update the screen, method already exists
        }

        private void AddHouseRule(HouseRuleServer rule, int index, int textIndex)
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
            ruleNumber.Text = (textIndex + 1).ToString();
            ruleNumber.Tag = index + 1;

            AddHouseRuleRow(ruleNumber, ruleLabel, disapprove);
        }

        public void AddHouseRuleRow(Label ruleNumber, Label ruleLabel, Button disapprove)
        {
            int newRow = pnlHouseRules.RowCount + 1;

            disapprove.Enabled = houseRules.AllRules[Convert.ToInt32(ruleNumber.Tag) - 1].StudentsApproval[student.ID];
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
                int index = Convert.ToInt32(ruleNumber.Tag) - 1;

                disapprove.Enabled = false;
                disapprove.BackColor = Color.FromArgb(210, 210, 210);
                houseRules.AllRules[index].StudentsApproval[this.student.ID] = false;

                server.UpdateHouseRules(houseRules);
                RulesUpdateTick();
                UpdatesTick();
            });

            // creates a new row
            pnlHouseRules.RowCount = newRow;
            pnlHouseRules.Controls.Add(ruleNumber, 0, newRow);
            pnlHouseRules.Controls.Add(ruleLabel, 1, newRow);
            pnlHouseRules.Controls.Add(disapprove, 3, newRow);

            //pnlHouseRules.Update(); // update the screen, method already exists
        }

        private void BtnComplain_Click(object sender, EventArgs e)
        {
            //If a Complaint Form does not already exist, create one
            if (complaintForm == null)
            {
                complaintForm = new AddComplainStudent(houseRules, mandatoryRules, student);
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
            UpdatesTick();
            if (_messages.AllMessages.Count != tbChatStudent.Controls.Count) // If misplaced, please place it somewhere else :)
            {
                //pnlChat.SuspendLayout();
                tbChatStudent.Controls.Clear();

                foreach (ChatMessage m in _messages.AllMessages)
                {
                    AddMessages(m);
                }
                //pnlChat.ResumeLayout();
            }
        }

        private void UpdatesTick()
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

                server.UpdateHouseRules(houseRules);
            }

            //If a complaint has been filed to the textbox in the Complaint Form and 
            //the Add button has been pressed, get the complaint from that textbox
            if (AddComplainStudent.ruleBroken != "")
            {
                Complaint complaint = new Complaint();
                complaint.BrokenBy = AddComplainStudent.IDOfRuleBreaker;
                complaint.ComplaintText = AddComplainStudent.ruleBroken;
                complaint.FiledBy = AddComplainStudent.IDOfComplainer;
                complaint.FiledDate = DateTime.Now;
                complaint.ID = complaints.AllComplaints.Count;
                complaints.AllComplaints.Add(complaint);

                AddComplainStudent.ruleBroken = "";
                AddComplainStudent.IDOfRuleBreaker = 0;
                AddComplainStudent.IDOfComplainer = 0;

                server.UpdateComplaints(complaints);
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
            RulesUpdateTick();
        }

        public void RulesUpdateTick(bool showUpdate = true)
        {
            fUpdating updateForm = new fUpdating();

            MandatoryRules mr = server.GetMandatoryRules(student.HouseNumber);
            if (mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count / 2 ||
                mr.AllRules.Count != pnlMandatoryRules.Controls.Count / 2)
            {
                mandatoryRules = mr;

                updateForm = new fUpdating();

                if (showUpdate)
                {
                    Task.Run(() =>
                    {
                        updateForm.ShowDialog();
                    });
                }

                pnlMandatoryRules.SuspendLayout();
                pnlMandatoryRules.Controls.Clear();

                foreach (MandatoryRuleServer rule in mr.AllRules)
                {
                    AddMandatoryRule(rule, mr.AllRules.IndexOf(rule));
                }
                pnlMandatoryRules.ResumeLayout();

                if (showUpdate)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        while (true)
                        {
                            try
                            {
                                updateForm.Close();
                                break;
                            }
                            catch { continue; }
                        }
                    });
                }
            }

            HouseRules hr = server.GetHouseRules(student.HouseNumber);
            if (houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4 ||
                hr.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4)
            {
                houseRules = hr;

                updateForm = new fUpdating();

                if (showUpdate)
                {
                    Task.Run(() =>
                    {
                        updateForm.ShowDialog();
                    });
                }

                pnlNotifications.Controls.Clear();
                pnlNotifications.SuspendLayout();

                pnlHouseRules.SuspendLayout();
                pnlHouseRules.Controls.Clear();

                int approved = 0;
                int disapproved = 0;
                foreach (HouseRuleServer rule in houseRules.AllRules)
                {
                    if (rule.ApprovalState == false)
                    {
                        AddNotificationsRule(rule, houseRules.AllRules.IndexOf(rule), disapproved);
                        disapproved++;
                    }
                    else
                    {
                        AddHouseRule(rule, houseRules.AllRules.IndexOf(rule), approved);
                        approved++;
                    }
                }
                pnlNotifications.ResumeLayout();
                pnlHouseRules.ResumeLayout();

                if (showUpdate)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        while (true)
                        {
                            try
                            {
                                updateForm.Close();
                                break;
                            }
                            catch { continue; }
                        }
                    });
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
                        updateForm = new fUpdating();

                        if (showUpdate)
                        {
                            Task.Run(() =>
                            {
                                updateForm.ShowDialog();
                            });
                        }

                        houseRules.AllRules[i].ApprovalState = true;
                        pnlNotifications.SuspendLayout();
                        pnlNotifications.Controls.Clear();
                        pnlHouseRules.SuspendLayout();
                        pnlHouseRules.Controls.Clear();

                        int approved = 0;
                        int disapproved = 0;
                        foreach (HouseRuleServer rule in houseRules.AllRules)
                        {
                            if (rule.ApprovalState == false)
                            {
                                AddNotificationsRule(rule, houseRules.AllRules.IndexOf(rule), disapproved);
                                disapproved++;
                            }
                            else
                            {
                                AddHouseRule(rule, houseRules.AllRules.IndexOf(rule), approved);
                                approved++;
                            }
                        }
                        pnlNotifications.ResumeLayout();
                        pnlHouseRules.ResumeLayout();

                        if (showUpdate)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                while (true)
                                {
                                    try
                                    {
                                        updateForm.Close();
                                        break;
                                    }
                                    catch { continue; }
                                }
                            });
                        }
                    }
                }
                else
                {
                    if (houseRules.AllRules[i].ApprovalState == true)
                    {
                        updateForm = new fUpdating();

                        if (showUpdate)
                        {
                            Task.Run(() =>
                            {
                                updateForm.ShowDialog();
                            });
                        }

                        houseRules.AllRules[i].ApprovalState = false;
                        pnlNotifications.SuspendLayout();
                        pnlNotifications.Controls.Clear();
                        pnlHouseRules.SuspendLayout();
                        pnlHouseRules.Controls.Clear();

                        int approved = 0;
                        int disapproved = 0;
                        foreach (HouseRuleServer rule in houseRules.AllRules)
                        {
                            if (rule.ApprovalState == false)
                            {
                                AddNotificationsRule(rule, houseRules.AllRules.IndexOf(rule), disapproved);
                                disapproved++;
                            }
                            else
                            {
                                AddHouseRule(rule, houseRules.AllRules.IndexOf(rule), approved);
                                approved++;
                            }
                        }
                        pnlNotifications.ResumeLayout();
                        pnlHouseRules.ResumeLayout();

                        if (showUpdate)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                while (true)
                                {
                                    try
                                    {
                                        updateForm.Close();
                                        break;
                                    }
                                    catch { continue; }
                                }
                            });
                        }
                    }
                }
            }
        }

        // Method for drawing the required amount of UserControls
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

        private void tabCtrlAdmin_TabIndexChanged(object sender, EventArgs e)
        {
            fUpdating updateForm = new fUpdating();

            Task.Run(() =>
            {
                try
                {
                    updateForm.ShowDialog();
                }
                catch { }
            });


            if (tabCtrlAdmin.SelectedIndex == 0)
            {
                schedules.Clear();
                HouseRules houseRules = new HouseRules();

                ServerConnection serverConnection = new ServerConnection();
                houseRules = server.GetHouseRules(student.HouseNumber);


                panel5.SuspendLayout();
                for (int i = 0; i < houseRules.AllRules.Count; i++)
                {
                    Schedule currentScheduleItem = new Schedule(student, i, houseRules);
                    if (currentScheduleItem.GetID() == student.ID)
                    {

                        schedules.Add(currentScheduleItem);

                    }
                }




                SortArray();

                for (int i = 0; i < schedules.Count; i++)
                {

                    schedules[i].Name = "Task";
                    //                    schedules[i].Size = new System.Drawing.Size(panel5.Width - 10, 20);
                    //                    schedules[i].Location = new System.Drawing.Point(10, panel5.Top - schedules.Count * schedules[0].);
                    schedules[i].TabIndex = 0;
                    schedules[i].Dock = DockStyle.Top;
                    panel5.Controls.Add(schedules[i]);

                }



                panel5.ResumeLayout();
                /*Thread.Sleep(500);
                */
            }

            Invoke((MethodInvoker)delegate
            {
                while (true)
                {
                    try
                    {
                        updateForm.Close();
                        break;
                    }
                    catch
                    {
                        //Thread.Sleep(100);
                    }
                }
            });

        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        // --------------------------------------- Chat -----------------//
        private void AddMessages(ChatMessage msg)
        {
            int newrow = tbChatStudent.RowCount + 1;
            Label Chat = new Label();
            Chat.Text = $"{msg.FiledDate} Student: {msg.MessageText}"; // no clue how to add a studentname :/
            Chat.AutoSize = true;

            tbChatStudent.RowCount = newrow;
            tbChatStudent.Controls.Add(Chat, 0, newrow);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (textChat.Text != "")
            {
                ChatMessage NewMsg = new ChatMessage();

                NewMsg.MessageText = textChat.Text;
                NewMsg.FiledBy = 2; // ???? XD
                NewMsg.FiledDate = DateTime.Now;
                _messages.AllMessages.Add(NewMsg);
                server.UpdateMessages(_messages);

                textChat.Clear();

            }
            else
            {
                MessageBox.Show("Please enter a valid rule");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbChat.Controls.Clear();
            _messages.AllMessages.Clear();

            server.UpdateMessages(_messages);
        }
    }
}