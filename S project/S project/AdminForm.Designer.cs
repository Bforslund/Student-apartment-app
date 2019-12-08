namespace S_project
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.lblHello = new System.Windows.Forms.Label();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.tabCtrlAdmin = new System.Windows.Forms.TabControl();
            this.Rules = new System.Windows.Forms.TabPage();
            this.pnlHouseRules = new System.Windows.Forms.Panel();
            this.pnlMandatoryRules = new System.Windows.Forms.Panel();
            this.lbxMandatoryRules = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.pnlBackHouseRules = new System.Windows.Forms.Panel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.pnlBackMandatoryRules = new System.Windows.Forms.Panel();
            this.lblMandatoryRules = new System.Windows.Forms.Label();
            this.Complaints = new System.Windows.Forms.TabPage();
            this.pnlBackComplaints = new System.Windows.Forms.Panel();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearChecked = new System.Windows.Forms.Button();
            this.pnlComplaints = new System.Windows.Forms.Panel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerRules = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.tabCtrlAdmin.SuspendLayout();
            this.Rules.SuspendLayout();
            this.pnlMandatoryRules.SuspendLayout();
            this.pnlBackHouseRules.SuspendLayout();
            this.pnlBackMandatoryRules.SuspendLayout();
            this.Complaints.SuspendLayout();
            this.pnlBackComplaints.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHello.Location = new System.Drawing.Point(8, 16);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(219, 24);
            this.lblHello.TabIndex = 8;
            this.lblHello.Text = "Hello, StudentName";
            // 
            // pctbxBack
            // 
            this.pctbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.ErrorImage")));
            this.pctbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pctbxBack.Image")));
            this.pctbxBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.InitialImage")));
            this.pctbxBack.Location = new System.Drawing.Point(759, 16);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 7;
            this.pctbxBack.TabStop = false;
            this.pctbxBack.Click += new System.EventHandler(this.PctbxBack_Click);
            // 
            // tabCtrlAdmin
            // 
            this.tabCtrlAdmin.Controls.Add(this.Rules);
            this.tabCtrlAdmin.Controls.Add(this.Complaints);
            this.tabCtrlAdmin.Location = new System.Drawing.Point(12, 43);
            this.tabCtrlAdmin.Name = "tabCtrlAdmin";
            this.tabCtrlAdmin.SelectedIndex = 0;
            this.tabCtrlAdmin.Size = new System.Drawing.Size(783, 448);
            this.tabCtrlAdmin.TabIndex = 6;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.pnlHouseRules);
            this.Rules.Controls.Add(this.pnlMandatoryRules);
            this.Rules.Controls.Add(this.listBox1);
            this.Rules.Controls.Add(this.btnAddRule);
            this.Rules.Controls.Add(this.pnlBackHouseRules);
            this.Rules.Controls.Add(this.pnlBackMandatoryRules);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 25);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(775, 419);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.AutoScroll = true;
            this.pnlHouseRules.Location = new System.Drawing.Point(319, 53);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.Size = new System.Drawing.Size(450, 363);
            this.pnlHouseRules.TabIndex = 7;
            // 
            // pnlMandatoryRules
            // 
            this.pnlMandatoryRules.AutoScroll = true;
            this.pnlMandatoryRules.Controls.Add(this.lbxMandatoryRules);
            this.pnlMandatoryRules.Location = new System.Drawing.Point(3, 53);
            this.pnlMandatoryRules.Name = "pnlMandatoryRules";
            this.pnlMandatoryRules.Size = new System.Drawing.Size(294, 311);
            this.pnlMandatoryRules.TabIndex = 6;
            // 
            // lbxMandatoryRules
            // 
            this.lbxMandatoryRules.FormattingEnabled = true;
            this.lbxMandatoryRules.ItemHeight = 19;
            this.lbxMandatoryRules.Location = new System.Drawing.Point(19, 29);
            this.lbxMandatoryRules.Name = "lbxMandatoryRules";
            this.lbxMandatoryRules.Size = new System.Drawing.Size(255, 137);
            this.lbxMandatoryRules.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(194)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(303, -3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 422);
            this.listBox1.TabIndex = 3;
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnAddRule.Location = new System.Drawing.Point(-9, 365);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(321, 50);
            this.btnAddRule.TabIndex = 5;
            this.btnAddRule.Text = "Add New Rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // pnlBackHouseRules
            // 
            this.pnlBackHouseRules.AutoScroll = true;
            this.pnlBackHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackHouseRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlBackHouseRules.Location = new System.Drawing.Point(311, 0);
            this.pnlBackHouseRules.Name = "pnlBackHouseRules";
            this.pnlBackHouseRules.Size = new System.Drawing.Size(468, 47);
            this.pnlBackHouseRules.TabIndex = 2;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Location = new System.Drawing.Point(176, 16);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(107, 19);
            this.lblHouseRules.TabIndex = 6;
            this.lblHouseRules.Text = "House rules";
            // 
            // pnlBackMandatoryRules
            // 
            this.pnlBackMandatoryRules.AutoScroll = true;
            this.pnlBackMandatoryRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackMandatoryRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackMandatoryRules.Controls.Add(this.lblMandatoryRules);
            this.pnlBackMandatoryRules.Location = new System.Drawing.Point(-7, 0);
            this.pnlBackMandatoryRules.Name = "pnlBackMandatoryRules";
            this.pnlBackMandatoryRules.Size = new System.Drawing.Size(314, 47);
            this.pnlBackMandatoryRules.TabIndex = 1;
            // 
            // lblMandatoryRules
            // 
            this.lblMandatoryRules.AutoSize = true;
            this.lblMandatoryRules.Location = new System.Drawing.Point(89, 16);
            this.lblMandatoryRules.Name = "lblMandatoryRules";
            this.lblMandatoryRules.Size = new System.Drawing.Size(144, 19);
            this.lblMandatoryRules.TabIndex = 5;
            this.lblMandatoryRules.Text = "Mandatory rules";
            // 
            // Complaints
            // 
            this.Complaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Complaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Complaints.Controls.Add(this.pnlBackComplaints);
            this.Complaints.Controls.Add(this.btnClearAll);
            this.Complaints.Controls.Add(this.btnClearChecked);
            this.Complaints.Controls.Add(this.pnlComplaints);
            this.Complaints.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Complaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Complaints.Location = new System.Drawing.Point(4, 25);
            this.Complaints.Name = "Complaints";
            this.Complaints.Padding = new System.Windows.Forms.Padding(3);
            this.Complaints.Size = new System.Drawing.Size(775, 419);
            this.Complaints.TabIndex = 0;
            this.Complaints.Text = "Complaints";
            // 
            // pnlBackComplaints
            // 
            this.pnlBackComplaints.AutoScroll = true;
            this.pnlBackComplaints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackComplaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackComplaints.Controls.Add(this.lblComplaints);
            this.pnlBackComplaints.Location = new System.Drawing.Point(-1, 0);
            this.pnlBackComplaints.Name = "pnlBackComplaints";
            this.pnlBackComplaints.Size = new System.Drawing.Size(779, 47);
            this.pnlBackComplaints.TabIndex = 8;
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Location = new System.Drawing.Point(343, 16);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(102, 19);
            this.lblComplaints.TabIndex = 5;
            this.lblComplaints.Text = "Complaints";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnClearAll.Location = new System.Drawing.Point(457, 365);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(321, 50);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All Complaints";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnClearChecked
            // 
            this.btnClearChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnClearChecked.Location = new System.Drawing.Point(-9, 365);
            this.btnClearChecked.Name = "btnClearChecked";
            this.btnClearChecked.Size = new System.Drawing.Size(321, 50);
            this.btnClearChecked.TabIndex = 6;
            this.btnClearChecked.Text = "Clear Checked Complaints";
            this.btnClearChecked.UseVisualStyleBackColor = false;
            // 
            // pnlComplaints
            // 
            this.pnlComplaints.AutoScroll = true;
            this.pnlComplaints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlComplaints.BackColor = System.Drawing.Color.Transparent;
            this.pnlComplaints.Location = new System.Drawing.Point(6, 53);
            this.pnlComplaints.Name = "pnlComplaints";
            this.pnlComplaints.Size = new System.Drawing.Size(761, 308);
            this.pnlComplaints.TabIndex = 0;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // timerRules
            // 
            this.timerRules.Enabled = true;
            this.timerRules.Interval = 1000;
            this.timerRules.Tick += new System.EventHandler(this.TimerRules_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(807, 503);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pctbxBack);
            this.Controls.Add(this.tabCtrlAdmin);
            this.Name = "AdminForm";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.tabCtrlAdmin.ResumeLayout(false);
            this.Rules.ResumeLayout(false);
            this.pnlMandatoryRules.ResumeLayout(false);
            this.pnlBackHouseRules.ResumeLayout(false);
            this.pnlBackHouseRules.PerformLayout();
            this.pnlBackMandatoryRules.ResumeLayout(false);
            this.pnlBackMandatoryRules.PerformLayout();
            this.Complaints.ResumeLayout(false);
            this.pnlBackComplaints.ResumeLayout(false);
            this.pnlBackComplaints.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.TabControl tabCtrlAdmin;
        private System.Windows.Forms.TabPage Complaints;
        private System.Windows.Forms.Panel pnlComplaints;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.Panel pnlHouseRules;
        private System.Windows.Forms.Panel pnlMandatoryRules;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Panel pnlBackHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlBackMandatoryRules;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.Button btnClearChecked;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel pnlBackComplaints;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.ListBox lbxMandatoryRules;
        private System.Windows.Forms.Timer timerRules;
    }
}