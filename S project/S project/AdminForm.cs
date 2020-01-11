﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerLibrary;

namespace S_project
{
    public partial class AdminForm : Form
    {
        private ServerConnection _server;
        private int _houseNumber;
        private MandatoryRules _mandatoryRules = new MandatoryRules();
        private HouseRules _houseRules;
        private Complaints _complaints;
        private ChatHistory _messages;
        private UserInfo _user;
        UdpClient udpClient = new UdpClient();

        public AdminForm(ServerConnection server, int houseNumber, UserInfo user)
        {
            InitializeComponent();

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
                        _mandatoryRules = server.GetMandatoryRules(_user.HouseNumber);
                        _houseRules = server.GetHouseRules(_user.HouseNumber);
                        _complaints = server.GetComplaints(_user.HouseNumber);
                        _messages = server.GetMessages(_user.HouseNumber);
                    };
                }
            });

            _houseNumber = houseNumber;
            _server = server;
            _mandatoryRules = server.GetMandatoryRules(houseNumber);
            _houseRules = server.GetHouseRules(houseNumber);
            _complaints = server.GetComplaints(houseNumber);
            _messages = server.GetMessages(houseNumber);
            _user = user;

            UpdateTick(false);
        }

        private void GoBackToLogin()
        {
            Login loginForm = new Login();
            //udpClient.Close();
            loginForm.Show();
            this.Close();
        }

        private void PctbxBack_Click(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            button.Enabled = false;

            GoBackToLogin();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pctbxBack.Enabled)
                Environment.Exit(0);
            pctbxBack.Enabled = true;
        }

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            new AddRuleAdmin(_server, _houseNumber, _mandatoryRules).Show();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateTick();
        }

        private void UpdateTick(bool showUpdate = true)
        {
            if (_mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count / 3)
            {
                //_mandatoryRules = mr;
                UpdateMandatoryRulesLayout(_mandatoryRules, showUpdate);
            }

            if (_houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3)
            {
                //_houseRules = hr;
                UpdateHouseRulesLayout(_houseRules, showUpdate);
            }

            if (_complaints.AllComplaints.Count != pnlComplaints.Controls.Count)
            {
                pnlComplaints.SuspendLayout();
                pnlComplaints.Controls.Clear();

                foreach (Complaint complaint in _complaints.AllComplaints)
                {
                    AddComplaint(complaint);
                }

                pnlComplaints.ResumeLayout();
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

        private void UpdateMandatoryRulesLayout(MandatoryRules mr, bool showUpdate)
        {
            fUpdating updateForm = new fUpdating();

            if (showUpdate)
            {
                Task.Run(() =>
                {
                    updateForm.ShowDialog();
                });
            }

            pnlMandatoryRules.SuspendLayout();
            pnlMandatoryRules.Controls.Clear();

            foreach (MandatoryRule rule in mr.AllRules)
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

        private void UpdateHouseRulesLayout(HouseRules hr, bool showUpdate)
        {
            fUpdating updateForm = new fUpdating();

            if (showUpdate)
            {
                Task.Run(() =>
                {
                    updateForm.ShowDialog();
                });
            }

            pnlHouseRules.SuspendLayout();
            pnlHouseRules.Controls.Clear();

            foreach (HouseRule rule in hr.AllRules)
            {
                AddHouseRule(rule, hr.AllRules.IndexOf(rule));
            }

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

        private void AddHouseRule(HouseRule rule, int index) {
           
            Button removeRuleButton = new Button();
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            removeRuleButton.Size = new Size(30, 25);
            removeRuleButton.Text = "x";
            ruleNumber.Text = (index + 1).ToString();
            AddHouseRuleRow(ruleNumber, ruleLabel, removeRuleButton);
        }
        
        public void AddHouseRuleRow(Label ruleNumber, Label ruleLabel, Button removeRuleButton) { 
            int newRow = pnlHouseRules.RowCount + 1;

            removeRuleButton.Click += RemoveHouseRuleButton_Click;
            removeRuleButton.Tag = ruleNumber.Text;

            pnlHouseRules.RowCount = newRow;
            pnlHouseRules.Controls.Add(ruleNumber, 0, newRow);
            pnlHouseRules.Controls.Add(ruleLabel, 1, newRow);
            pnlHouseRules.Controls.Add(removeRuleButton, 2, newRow);
        }

        private void RemoveHouseRuleButton_Click(object sender, EventArgs e)
        {           
            int index = Convert.ToInt32(((Button)sender).Tag) - 1;
            _houseRules.AllRules.RemoveAt(index);

            UpdateHouseRulesLayout(_houseRules, true);
            _server.UpdateHouseRules(_houseRules);
        }

        private void AddMandatoryRule(MandatoryRule rule, int index)
        {
            // creating new labels and buttons
            Button removeRuleButton = new Button();
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            removeRuleButton.Size = new Size(30, 25);
            removeRuleButton.Text = "x";
            ruleNumber.Text = (index + 1).ToString();

            AddMandatoryRuleRow(ruleNumber, ruleLabel, removeRuleButton);
        }

        public void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel, Button removeRuleButton)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;
            // when you click it hides everything.
            removeRuleButton.Click += RemoveMandatoryRuleButton_Click;
            removeRuleButton.Tag = ruleNumber.Text;

            pnlMandatoryRules.RowCount = newRow; // creates a new row
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow); // Add the rulenumber label to coloum 0, and on the new row
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);
            pnlMandatoryRules.Controls.Add(removeRuleButton, 2, newRow);

            //#####  Commented line below to speed up updating and remove flickering 
            //pnlMandatoryRules.Update(); // update the screen, method already exists
        }

        private void RemoveMandatoryRuleButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((Button)sender).Tag) - 1;
            _mandatoryRules.AllRules.RemoveAt(index);

            UpdateMandatoryRulesLayout(_mandatoryRules, true);
            _server.UpdateMandatoryRules(_mandatoryRules);
        }

        private void AddComplaint(Complaint complaint)
        {  
            CheckBox box = new CheckBox();
            string complaintFiler;
            if(complaint.FiledBy == -1)
            {
                complaintFiler = "Anonymous";
            }
            else
            {
                complaintFiler = _user.StudentsInfo[complaint.FiledBy];
            }

            box.Text = $"Filed by: {complaintFiler}; Complaint: {complaint.ComplaintText}";

            box.Padding = new Padding(10, 0, 0, 0);
            box.Size = new Size(30, 30);
            box.Dock = DockStyle.Top;
            int newRow = tbComplaints.RowCount + 1;
            //tbComplaints.Controls.Add(box, 1, newRow);
            pnlComplaints.Controls.Add(box);
        }       

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            //tbComplaints.Controls.Clear();
            pnlComplaints.Controls.Clear();
            _complaints.AllComplaints.Clear();

            _server.UpdateComplaints(_complaints);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            List<CheckBox> boxes = pnlComplaints.Controls.OfType<CheckBox>().ToList(); // it finds all the controls that are checkbox, 
           
            /*the results are put in the list. So the list for sure only contains checkboxes (we dont know since controls could be anything)
            for (int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].Checked)
                {
                    boxes[i].Dispose();
                    _complaints.AllComplaints.RemoveAt(i);
                }
            }*/

            foreach (var box in boxes.FindAll(x => x.Checked))
            {
                //boxes[boxes.IndexOf(box)].Dispose();
                _complaints.AllComplaints.RemoveAt(boxes.IndexOf(box));
                boxes.Remove(box);
            }

            _server.UpdateComplaints(_complaints);
        }

        private void AddMessages(ChatMessage msg) 
        {
            ucChatMessage chatMessage = new ucChatMessage(msg.MessageText, $"{msg.FiledDate}", _user.StudentsInfo[msg.FiledBy]);
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
                NewMsg.FiledBy = _user.ID; // ???? XD
                NewMsg.FiledDate = DateTime.Now;
                _messages.AllMessages.Add(NewMsg);

                _server.UpdateMessages(_messages);

                textChat.Clear();
                UpdateTick();
            }
            else
            {
                MessageBox.Show("Please enter a valid rule");
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
    }
}
