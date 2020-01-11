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
        UdpClient udpClient = new UdpClient();

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

            Task.Run(() =>
            {
                udpClient.Client.Bind(new IPEndPoint(0, server.GetAvailableUdpPort()));

                while (true)
                {
                    Thread.Sleep(200);

                    int count = udpClient.Client.Available;
                    byte[] msg = new byte[count];

                    if (msg.Length == 0)
                        continue;

                    udpClient.Client.Receive(msg);

                    string message = Encoding.Default.GetString(msg, 0, msg.Length);

                    if (message.Contains("Updated"))
                    {
                        while (ServerConnection.Connected)
                            Thread.Sleep(25);
                        mandatoryRules = server.GetMandatoryRules(student.HouseNumber);

                        while (ServerConnection.Connected)
                            Thread.Sleep(25);
                        houseRules = server.GetHouseRules(student.HouseNumber);

                        while (ServerConnection.Connected)
                            Thread.Sleep(25);
                        complaints = server.GetComplaints(student.HouseNumber);

                        while (ServerConnection.Connected)
                            Thread.Sleep(25);
                        _messages = server.GetMessages(student.HouseNumber);
                    };
                }
            });

            ScheduleUpdate(false);

            timerRules.Start();
            timerUpdate.Start();

            RulesUpdateTick(false);
            UpdatesTick();
        }

        #region Helpers
        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            //udpClient.Close();
            loginForm.Show();
            this.Close();
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

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {           
            Environment.Exit(0);
        }
        #endregion

        #region Working with Mandatory Rules
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
        
        public void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;

            // creates a new row
            pnlMandatoryRules.RowCount = newRow;
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow);
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);

            //pnlMandatoryRules.Update(); // update the screen, method already exists
        }
        #endregion

        #region Working with Notifications
        private void AddNotificationsRule(HouseRule rule, int index , int textIndex)
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

                while (ServerConnection.Connected)
                {
                    Thread.Sleep(25);
                }
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

                while (ServerConnection.Connected)
                {
                    Thread.Sleep(25);
                }
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
        #endregion

        #region Working with House Rules
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

                while (ServerConnection.Connected)
                {
                    Thread.Sleep(25);
                }
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
        #endregion

        #region Timers Ticks
        private void TimerUpdates_Tick(object sender, EventArgs e)
        {
            UpdatesTick();
        }

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

                houseRule.StudentsApproval[student.ID] = true;
                houseRules.AllRules.Add(houseRule);
                AddRuleStudent.ruleName = "";
                AddRuleStudent.repeatRule = 0;

                while (ServerConnection.Connected)
                    Thread.Sleep(25);
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

                while (ServerConnection.Connected)
                {
                    Thread.Sleep(25);
                }
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

            if (mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count / 2)
                //|| mr.AllRules.Count != pnlMandatoryRules.Controls.Count / 2)
            {
                //mandatoryRules = mr;

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

                foreach (MandatoryRule rule in mandatoryRules.AllRules)
                {
                    AddMandatoryRule(rule, mandatoryRules.AllRules.IndexOf(rule));
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

            //HouseRules hr = server.GetHouseRules(student.HouseNumber);
            if (houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4 )//||
                //hr.AllRules.Count != pnlHouseRules.Controls.Count / 3 + pnlNotifications.Controls.Count / 4)
            {
                //houseRules = hr;

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
                        updateForm = new fUpdating();

                        if (showUpdate)
                        {
                            Task.Run(() =>
                            {
                                updateForm.ShowDialog();
                            });
                        }

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
                    if (hr.AllRules[i].ApprovalState == true)
                    {
                        updateForm = new fUpdating();

                        if (showUpdate)
                        {
                            Task.Run(() =>
                            {
                                updateForm.ShowDialog();
                            });
                        }

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

            //ChatHistory ch = server.GetMessages(student.HouseNumber);
            if (_messages.AllMessages.Count != panelChat.Controls.Count)// ||
                //ch.AllMessages.Count != panelChat.Controls.Count)
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

        private void tabCtrlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrlAdmin.SelectedIndex == 0)
                ScheduleUpdate();
        }

        private void ScheduleUpdate(bool showUpdate = true)
        {            
            fUpdating updateForm = new fUpdating();

            if (showUpdate)
            {
                Task.Run(() =>
                {
                    try
                    {
                        updateForm.ShowDialog();
                    }
                    catch { }
                });
            }

            schedules.Clear();
            panel5.Controls.Clear();

            panel5.SuspendLayout();
            for (int i = 0; i < houseRules.AllRules.Count; i++)
            {
                Schedule currentScheduleItem = new Schedule(student, i, houseRules);
                if (currentScheduleItem.GetID() == student.ID)
                {
                    schedules.Add(currentScheduleItem);
                }
                else
                {
                    currentScheduleItem.DisableDoneBox();
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
                schedules[i].PerformAutoScale();
                schedules[i].PerformLayout();
                panel5.Controls.Add(schedules[i]);
            }

            panel5.ResumeLayout();
            /*Thread.Sleep(500);
            */

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
                        catch
                        {
                        //Thread.Sleep(100);
                    }
                    }
                });
            }
        }   
        
        #endregion

        #region Chat
        private void AddMessages(ChatMessage msg)
        {
            ucChatMessage chatMessage = new ucChatMessage(msg.MessageText, $"{msg.FiledDate}", student.StudentsInfo[msg.FiledBy]);
            chatMessage.Dock = DockStyle.Top;

            chatMessage.PerformAutoScale();
            chatMessage.PerformLayout();

            panelChat.Controls.Add(chatMessage);
            panelChat.Controls.SetChildIndex(chatMessage, 0);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (textChat.Text != "")
            {
                ChatMessage NewMsg = new ChatMessage();

                NewMsg.MessageText = textChat.Text;
                NewMsg.FiledBy = student.ID; // ???? XD
                NewMsg.FiledDate = DateTime.Now;
                _messages.AllMessages.Add(NewMsg);

                while (ServerConnection.Connected)
                    Thread.Sleep(25);
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

        private void textChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSend.PerformClick();
                textChat.Text = "";
            }
        }

        private void panel9_VisibleChanged(object sender, EventArgs e)
        {
            panelChat.VerticalScroll.Value = panelChat.VerticalScroll.Maximum;
        }
        #endregion
    }
}