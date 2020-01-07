using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public AdminForm(ServerConnection server, int houseNumber, UserInfo user)
        {
            InitializeComponent();

            _houseNumber = houseNumber;
            _server = server;
            _mandatoryRules = server.GetMandatoryRules(houseNumber);
            _houseRules = server.GetHouseRules(houseNumber);
            _complaints = server.GetComplaints(houseNumber);
            _messages = server.GetMessages(houseNumber);
            _user = user;
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

        private void BtnAddRule_Click(object sender, EventArgs e)
        {
            new AddRuleAdmin(_server, _houseNumber, _mandatoryRules).Show();
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {            
            MandatoryRules mr = _server.GetMandatoryRules(_houseNumber);
            if (_mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count / 3 ||
                mr.AllRules.Count != pnlMandatoryRules.Controls.Count / 3)
            {
                _mandatoryRules = mr;
                UpdateMandatoryRulesLayout(mr);
            }
                

            HouseRules hr = _server.GetHouseRules(_houseNumber);
            if (_houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3 ||
                hr.AllRules.Count != pnlHouseRules.Controls.Count / 3)
            {
                _houseRules = hr;
                UpdateHouseRulesLayout(hr);
            }
                
            if (_complaints.AllComplaints.Count != pnlComplaints.Controls.Count ||
                _server.GetComplaints(_houseNumber).AllComplaints.Count != pnlComplaints.Controls.Count)
            {
                pnlComplaints.SuspendLayout();
                pnlComplaints.Controls.Clear();

                foreach (Complaint complaint in _complaints.AllComplaints)
                {
                    AddComplaint(complaint);
                }

                pnlComplaints.ResumeLayout();
            }

            if (_messages.AllMessages.Count != tbChat.Controls.Count)
            {
                //pnlChat.SuspendLayout();
                tbChat.Controls.Clear();

                foreach (ChatMessage m in _messages.AllMessages)
                {
                    AddMessages(m);
                }
                //pnlChat.ResumeLayout();
            }
        }

        private void UpdateMandatoryRulesLayout(MandatoryRules mr)
        {
            fUpdating updateForm = new fUpdating();

            Task.Run(() =>
            {
                updateForm.ShowDialog();
            });

            pnlMandatoryRules.SuspendLayout();
            pnlMandatoryRules.Controls.Clear();

            foreach (MandatoryRuleServer rule in mr.AllRules)
            {
                AddMandatoryRule(rule, mr.AllRules.IndexOf(rule));
            }

            pnlMandatoryRules.ResumeLayout();
            Invoke((MethodInvoker)delegate
            {
                updateForm.Close();
            });
        }

        private void UpdateHouseRulesLayout(HouseRules hr)
        {
            fUpdating updateForm = new fUpdating();

            Task.Run(() =>
            {
                updateForm.ShowDialog();
            });

            pnlHouseRules.SuspendLayout();
            pnlHouseRules.Controls.Clear();

            foreach (HouseRuleServer rule in hr.AllRules)
            {
                AddHouseRule(rule, hr.AllRules.IndexOf(rule));
            }

            pnlHouseRules.ResumeLayout();
            Invoke((MethodInvoker)delegate
            {
                updateForm.Close();
            });
        }

        private void AddHouseRule(HouseRuleServer rule, int index) {
           
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

            UpdateHouseRulesLayout(_houseRules);
            _server.UpdateHouseRules(_houseRules);
        }

        private void AddMandatoryRule(MandatoryRuleServer rule, int index)
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

            UpdateMandatoryRulesLayout(_mandatoryRules);
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

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddMessages(ChatMessage msg) 
        { 
            int newrow = tbChat.RowCount + 1;
            Label Chat = new Label();
            Chat.Text = $"{msg.FiledDate} Admin: {msg.MessageText}";
            Chat.AutoSize = true;

            
            tbChat.RowCount = newrow;
            tbChat.Controls.Add(Chat, 0, newrow); 
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
                _server.UpdateMessages(_messages);

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

            _server.UpdateMessages(_messages);
        }
    }
}
