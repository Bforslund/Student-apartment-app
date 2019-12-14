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
    public partial class AdminForm : Form
    {
        private ServerConnection _server;
        private int _houseNumber;
        private MandatoryRules _mandatoryRules;
        private HouseRules _houseRules;
        private Complaints _complaints;

        public AdminForm(ServerConnection server, int houseNumber)
        {
            _houseNumber = houseNumber;
            _server = server;
            _mandatoryRules = server.GetMandatoryRules(houseNumber);
            _houseRules = server.GetHouseRules(houseNumber);
            _complaints = server.GetComplaints(houseNumber);

            InitializeComponent();
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
            if (_mandatoryRules.AllRules.Count != pnlMandatoryRules.Controls.Count /3)
            {
                pnlMandatoryRules.Controls.Clear();

                foreach (MandatoryRuleServer rule in _mandatoryRules.AllRules)
                {
                    AddMandatoryRule(rule);
                }
            }
            if (_houseRules.AllRules.Count != pnlHouseRules.Controls.Count / 3)
            {
                pnlHouseRules.Controls.Clear();

                foreach (HouseRuleServer rule in _houseRules.AllRules)
                {
                    AddHouseRule(rule);
                }
            }
            if (_complaints.AllComplaints.Count != tbComplaints.Controls.Count)
            {
                tbComplaints.Controls.Clear();

                foreach (Complaint complaint in _complaints.AllComplaints)
                {
                    AddComplaint(complaint);
                }
            }
        }

        private void AddHouseRule(HouseRuleServer rule) {
            // i have a button click to update now, but I want to update my list whenever a rule is sent. So When that is Done i will adjust this.

            Button removeRuleButton = new Button();
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            removeRuleButton.Size = new Size(30, 25);
            removeRuleButton.Text = "x";
            ruleNumber.Text = (rule.ID + 1).ToString();
            AddHouseRuleRow(ruleNumber, ruleLabel, removeRuleButton);
        }
        public void AddHouseRuleRow(Label ruleNumber, Label ruleLabel, Button removeRuleButton) { 
            int newRow = pnlHouseRules.RowCount + 1;

            removeRuleButton.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                ruleNumber.Dispose();
                ruleLabel.Dispose();
                removeRuleButton.Dispose();
                _houseRules.AllRules.RemoveAt(index);

                for (int i = 0; i < _houseRules.AllRules.Count; i++)
                {
                    _houseRules.AllRules[i].ID = i;
                }

                _server.UpdateHouseRules(_houseRules);
            });

            pnlHouseRules.RowCount = newRow;
            pnlHouseRules.Controls.Add(ruleNumber, 0, newRow);
            pnlHouseRules.Controls.Add(ruleLabel, 1, newRow);
            pnlHouseRules.Controls.Add(removeRuleButton, 2, newRow);
            pnlHouseRules.Update();
        }

        private void AddMandatoryRule(MandatoryRuleServer rule)
        {
            // creating new labels and buttons
            Button removeRuleButton = new Button();
            Label ruleLabel = new Label();
            Label ruleNumber = new Label();

            ruleLabel.Text = rule.RuleText;
            ruleLabel.AutoSize = true;
            removeRuleButton.Size = new Size(30, 25);
            removeRuleButton.Text = "x";
            ruleNumber.Text = (rule.ID + 1).ToString();

            AddMandatoryRuleRow(ruleNumber, ruleLabel, removeRuleButton);
        }

        public void AddMandatoryRuleRow(Label ruleNumber, Label ruleLabel, Button removeRuleButton)
        {
            int newRow = pnlMandatoryRules.RowCount + 1;
            // when you click it hides everything.
            removeRuleButton.Click += new EventHandler((s, ea) =>
            {
                int index = Convert.ToInt32(ruleNumber.Text) - 1;

                ruleNumber.Dispose();
                ruleLabel.Dispose();
                removeRuleButton.Dispose();
                _mandatoryRules.AllRules.RemoveAt(index);

                for (int i = 0; i < _mandatoryRules.AllRules.Count; i++)
                {
                    _mandatoryRules.AllRules[i].ID = i;
                }

                _server.UpdateMandatoryRules(_mandatoryRules);
            });

            pnlMandatoryRules.RowCount = newRow; // creates a new row
            pnlMandatoryRules.Controls.Add(ruleNumber, 0, newRow); // Add the rulenumber label to coloum 0, and on the new row
            pnlMandatoryRules.Controls.Add(ruleLabel, 1, newRow);
            pnlMandatoryRules.Controls.Add(removeRuleButton, 2, newRow);

            pnlMandatoryRules.Update(); // update the screen, method already exists
        }

        private void AddComplaint(Complaint complaint)
        {
  
            CheckBox box = new CheckBox();
            box.Text = $"{complaint.FiledBy} {complaint.ComplaintText}";
            box.AutoSize = true;
            int newRow = tbComplaints.RowCount + 1;
            tbComplaints.Controls.Add(box, 1, newRow);
        }

       

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            tbComplaints.Controls.Clear();
            _complaints.AllComplaints.Clear();

            _server.UpdateComplaints(_complaints);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            List<CheckBox> boxes = tbComplaints.Controls.OfType<CheckBox>().ToList(); // it finds all the controls that are checkbox, 
            //the results are put in the list. So the list for sure only contains checkboxes (we dont know since controls could be anything)
            for (int i = 0; i < boxes.Count; i++)
            {
                if (boxes[i].Checked)
                {
                    boxes[i].Dispose();
                    _complaints.AllComplaints.RemoveAt(i);
                }
            }

            _server.UpdateComplaints(_complaints);
        }
    }
}
