using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerLibrary;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Globalization;
using System.IO.Ports;

namespace S_project
{
    public partial class StudentForm : Form
    {
        private UserInfo student;
        public MandatoryRules mandatoryRules;
        public HouseRules houseRules = new HouseRules();
        private ServerConnection server;
        private ChatHistory _messages;

        //Initialize forms for Complaints and Rules
        AddComplainStudent complaintForm = null;
        AddRuleStudent ruleForm = null;
        List<Schedule> schedules = new List<Schedule>();
        Complaints complaints = new Complaints();
        UdpClient udpClient = new UdpClient();


        // Constructor to make the student form connect to the server
        // Sees if the server sends "updated", if so: updates
        public StudentForm(ServerConnection server, UserInfo student)
        {
            InitializeComponent();

            ThreadStart threadStart = new ThreadStart(updateTemperature);
            Thread t1 = new Thread(threadStart);
            t1.Start();

            Task.Run(() =>
            {
                udpClient.Client.Bind(new IPEndPoint(0, server.GetAvailableUdpPort()));

                int attempts = 0;
                string message = "";
                while (true)
                {
                    Thread.Sleep(100);
                    attempts++;

                    byte[] msg = new byte[udpClient.Client.Available];

                    if (msg.Length == 0 && attempts < 100)
                        continue;
                    else if (attempts >= 100) { }
                    else if (msg.Length == 0)
                        continue;

                    if (attempts < 100)
                    {
                        udpClient.Client.Receive(msg);
                        message = Encoding.Default.GetString(msg, 0, msg.Length);
                    }

                    if (message.Contains("Updated") || attempts >= 100)
                    {
                        student.StudentsInfo = server.GetUsersInfo(student.HouseNumber);
                        mandatoryRules = server.GetMandatoryRules(student.HouseNumber);
                        houseRules = server.GetHouseRules(student.HouseNumber);
                        complaints = server.GetComplaints(student.HouseNumber);
                        _messages = server.GetMessages(student.HouseNumber);

                        if (InvokeRequired)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                RulesUpdateTick();
                                UpdatesTick();
                                ScheduleUpdate();
                            });
                        }
                        else
                        {
                            RulesUpdateTick();
                            UpdatesTick();
                            ScheduleUpdate();
                        }
                    };

                    attempts = 0;
                }
            });

            this.student = student;
            this.server = server;
            lblHello.Text = "Hello, " + this.student.Name;

            mandatoryRules = server.GetMandatoryRules(student.HouseNumber);
            houseRules = server.GetHouseRules(student.HouseNumber);
            complaints = server.GetComplaints(student.HouseNumber);
            _messages = server.GetMessages(student.HouseNumber);

            ScheduleUpdate();

            timerUpdate.Start();

            RulesUpdateTick(false);
            UpdatesTick();
        }

        #region Helpers      
        private void BtnComplain_Click(object sender, EventArgs e)
        {
            //If a Complaint Form does not already exist, create one
            if (complaintForm == null)
            {
                complaintForm = new AddComplainStudent(houseRules, mandatoryRules, student, this);
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

        //Logout method
        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            loginForm.Show();
            Port1.Close();
            this.Close();
        }
        
        //Click on the logout button
        private void PctbxBack_Click(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            button.Enabled = false;

            GoBackToLogin();
        }
        
        //If you close form it will close the whole application
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pctbxBack.Enabled)
                Environment.Exit(0);
            pctbxBack.Enabled = true;
        }
        #endregion

        #region Working with Mandatory Rules
        //Adds new mandatory rule
        private void AddMandatoryRule(MandatoryRule rule, int index)
        {
            // creates new labels
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            ruleNumber.Text = (index + 1).ToString();

            AddMandatoryRuleRow(ruleNumber, ruleLabel);
        }
        
        //Adds new mandatory rule row in coresponding table layout
        public void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;

            // creates a new row
            pnlMandatoryRules.RowCount = newRow;
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow);
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);
        }
        #endregion

        #region Working with Notifications
        //Adds notification that a new rule is proposed
        private void AddNotificationsRule(HouseRule rule, int index, int textIndex)
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

        //Adds new notification row in coresponding table layout
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

                if (houseRules.AllRules[index].StudentsApproval.Values.All(x => x == false))
                    houseRules.AllRules.RemoveAt(index);

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
        }
        #endregion

        #region Working with House Rules
        //Adds notification that a new rule is proposed
        private void AddHouseRule(HouseRule rule, int index, int textIndex)
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
        
        //Adds new house rule row in coresponding table layout
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
        }
        #endregion

        #region Timers Ticks
        private void TimerUpdates_Tick(object sender, EventArgs e)
        {
            UpdatesTick();
        }
        
        //Checks if any complaints or rules where added
        private void UpdatesTick()
        {
            //If a rule has been added to the textbox in the Rule Form and 
            //the Add button has been pressed, get the rule from that textbox
            if (AddRuleStudent.ruleName != "")
            {
                HouseRule houseRule = new HouseRule();
                houseRule.ApprovalState = false;
                houseRule.ID = houseRules.AllRules.Count;
                houseRule.Interval = AddRuleStudent.repeatRule;
                houseRule.RuleText = AddRuleStudent.ruleName;
                houseRule.LastCompleted = DateTime.Now;
                houseRule.OnlyThisWeek = false;
                houseRule.StudentsApproval = new Dictionary<int, bool>();

                for (int i = 0; i < student.TotalStudentNumber; i++)
                {
                    houseRule.StudentsApproval.Add(i + 1, false);

                    //The order of students is kept sorted by their ID
                    houseRule.OrderOfStudents.Add(i + 1);
                }

                houseRule.CurrentStudentId = houseRule.OrderOfStudents[0];
                houseRule.StudentsApproval[student.ID] = true;

                houseRules.AllRules.Add(houseRule);

                AddRuleStudent.ruleName = "";
                AddRuleStudent.repeatRule = 0;

                RulesUpdateTick();
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

                //Updates form
                RulesUpdateTick();
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
        
        //Updates information about all rules in the form
        public void RulesUpdateTick(bool showUpdate = true)
        {
            //Chacks mandatory rules
            if (mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count / 2)
            {
                pnlMandatoryRules.SuspendLayout();
                pnlMandatoryRules.Controls.Clear();

                foreach (MandatoryRule rule in mandatoryRules.AllRules)
                {
                    AddMandatoryRule(rule, mandatoryRules.AllRules.IndexOf(rule));
                }
                pnlMandatoryRules.ResumeLayout();
            }

            //Checks house rules
            if (houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4)
            {
                pnlNotifications.Controls.Clear();
                pnlNotifications.SuspendLayout();

                pnlHouseRules.SuspendLayout();
                pnlHouseRules.Controls.Clear();

                int approved = 0;
                int disapproved = 0;
                foreach (HouseRule rule in houseRules.AllRules)
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
            }

            HouseRules hr = houseRules.Clone();
            
            for (int i = 0; i < hr.AllRules.Count; i++)
            {
                int numberOfApprovals = 0;

                for (int j = 0; j < student.TotalStudentNumber; j++)
                {
                    numberOfApprovals += Convert.ToInt32(hr.AllRules[i].StudentsApproval[j + 1]);
                }

                if (numberOfApprovals > student.TotalStudentNumber / 2)
                {
                    if (hr.AllRules[i].ApprovalState == false)
                    {
                        hr.AllRules[i].ApprovalState = true;
                        pnlNotifications.SuspendLayout();
                        pnlNotifications.Controls.Clear();
                        pnlHouseRules.SuspendLayout();
                        pnlHouseRules.Controls.Clear();

                        int approved = 0;
                        int disapproved = 0;
                        foreach (HouseRule rule in hr.AllRules)
                        {
                            if (rule.ApprovalState == false)
                            {
                                AddNotificationsRule(rule, hr.AllRules.IndexOf(rule), disapproved);
                                disapproved++;
                            }
                            else
                            {
                                AddHouseRule(rule, hr.AllRules.IndexOf(rule), approved);
                                approved++;
                            }
                        }
                        pnlNotifications.ResumeLayout();
                        pnlHouseRules.ResumeLayout();
                    }
                }
                else
                {
                    if (hr.AllRules[i].ApprovalState == true)
                    {
                        hr.AllRules[i].ApprovalState = false;
                        pnlNotifications.SuspendLayout();
                        pnlNotifications.Controls.Clear();
                        pnlHouseRules.SuspendLayout();
                        pnlHouseRules.Controls.Clear();

                        int approved = 0;
                        int disapproved = 0;
                        foreach (HouseRule rule in hr.AllRules)
                        {
                            if (rule.ApprovalState == false)
                            {
                                AddNotificationsRule(rule, hr.AllRules.IndexOf(rule), disapproved);
                                disapproved++;
                            }
                            else
                            {
                                AddHouseRule(rule, hr.AllRules.IndexOf(rule), approved);
                                approved++;
                            }
                        }
                        pnlNotifications.ResumeLayout();
                        pnlHouseRules.ResumeLayout();
                    }
                }
            }

            if (_messages.AllMessages.Count != panelChat.Controls.Count)
            {
                for (int i = panelChat.Controls.Count; i < _messages.AllMessages.Count; i++)
                {
                    AddMessages(_messages.AllMessages[i]);
                }
                panelChat.VerticalScroll.Value = panelChat.VerticalScroll.Maximum;
            }

        }
        #endregion

        #region Schedule
        // Method for drawing the required amount of UserControls
        // Method for sorting the list of UserControls
        private void SortArray()
        {
            Schedule temp;

            for (int i = 0; i < schedules.Count - 1; i++)
            {
                for (int j = 0; j < schedules.Count - i - 1; j++)
                {
                    if (schedules[j].GetDays() < schedules[j + 1].GetDays())
                    {
                        temp = schedules[j];
                        schedules[j] = schedules[j + 1];
                        schedules[j + 1] = temp;
                    }
                }
            }
        }
        
        //Updates schedule if it is selected
        private void tabCtrlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlAdmin.SelectedIndex == 0)
                ScheduleUpdate();
        }
        
        //Update schedule with new data
        public void ScheduleUpdate()
        {
            schedules.Clear();
            panel5.Controls.Clear();

            panel5.SuspendLayout();

            for (int i = 0; i < houseRules.AllRules.Count; i++)
            {
                if (houseRules.AllRules[i].ApprovalState)
                {
                    Schedule currentScheduleItem = new Schedule(student, i, houseRules, this);

                    schedules.Add(currentScheduleItem);
                }
            }
            
            SortArray();

            for (int i = 0; i < schedules.Count; i++)
            {
                schedules[i].Name = "Task";
                schedules[i].TabIndex = 0;
                schedules[i].Dock = DockStyle.Top;
                schedules[i].PerformAutoScale();
                schedules[i].PerformLayout();
                panel5.Controls.Add(schedules[i]);
            }

            panel5.ResumeLayout();
        }

        #endregion

        #region Chat
        //Adds new message to the chat
        private void AddMessages(ChatMessage msg)
        {
            ucChatMessage chatMessage = new ucChatMessage(msg.MessageText, $"{msg.FiledDate}", student.StudentsInfo[msg.FiledBy]);
            chatMessage.Dock = DockStyle.Top;

            chatMessage.PerformAutoScale();
            chatMessage.PerformLayout();

            panelChat.Controls.Add(chatMessage);
            panelChat.Controls.SetChildIndex(chatMessage, 0);
        }
        
        //Sends new message
        private void btSend_Click(object sender, EventArgs e)
        {
            if (textChat.Text != "")
            {
                ChatMessage NewMsg = new ChatMessage();

                NewMsg.MessageText = textChat.Text;
                NewMsg.FiledBy = student.ID;
                NewMsg.FiledDate = DateTime.Now;
                _messages.AllMessages.Add(NewMsg);

                server.UpdateMessages(_messages);

                textChat.Clear();
                RulesUpdateTick();
                UpdatesTick();
            }
            else
            {
                MessageBox.Show("Please enter a valid message");
            }
        }
        
        //If "Enter" is pressed message will be sent
        private void textChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSend.PerformClick();
                textChat.Text = "";
            }
        }

        private void panelChat_VisibleChanged(object sender, EventArgs e)
        {
            panelChat.VerticalScroll.Value = panelChat.VerticalScroll.Maximum;
        }
        #endregion

        #region Settings
        private void tbCurrentPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbCurrentPassword.PasswordChar = '\0';
        }

        private void tbCurrentPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbCurrentPassword.PasswordChar = '*';
        }

        private void tbNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbNewPassword.PasswordChar = '\0';
        }

        private void tbNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbNewPassword.PasswordChar = '*';
        }
        
        //Sends new password to the server
        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;

            DialogResult result = MessageBox.Show("Are you sure?", "Password change", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                bool changed = server.UpdatePassword(student.ID, tbNewPassword.Text, tbCurrentPassword.Text, student.HouseNumber);
                if (!changed)
                {
                    MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Password Changed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            button.Enabled = true;
        }
        #endregion

        #region Temperature
        //Runs in the background and updates temperature, if Arduino is available
        private void updateTemperature()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(10000);
                    
                    //Gets all available ports on the computer and tries to connect to it
                    foreach (string port in SerialPort.GetPortNames())
                    {
                        try
                        {
                            Port1.PortName = port;
                            Port1.Open();
                            Port1.ReadTimeout = 100;
                            Port1.ReadLine();
                            break;
                        }
                        catch { Port1.Close(); }
                    }

                    if (!Port1.IsOpen)
                        continue;

                    try
                    {
                        while (true)
                        {
                            string temperature;
                            temperature = Port1.ReadLine();
                            temperatureBox.Invoke(new Action(() => temperatureBox.Text = $"The tempeature is: {temperature.Replace("\r", "")} ℃"));
                        }
                    }
                    catch { continue; }
                }
            });
        }
        #endregion
    }
}