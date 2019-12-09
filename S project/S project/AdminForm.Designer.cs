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
            this.tabCtrlAdmin = new System.Windows.Forms.TabControl();
            this.Rules = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.houseRulesPane = new System.Windows.Forms.TableLayoutPanel();
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
            this.button1 = new System.Windows.Forms.Button();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mandatoryRulesPane = new System.Windows.Forms.TableLayoutPanel();
            this.tabCtrlAdmin.SuspendLayout();
            this.Rules.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBackHouseRules.SuspendLayout();
            this.pnlBackMandatoryRules.SuspendLayout();
            this.Complaints.SuspendLayout();
            this.pnlBackComplaints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlAdmin
            // 
            this.tabCtrlAdmin.Controls.Add(this.Rules);
            this.tabCtrlAdmin.Controls.Add(this.Complaints);
            this.tabCtrlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlAdmin.Location = new System.Drawing.Point(9, 12);
            this.tabCtrlAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.tabCtrlAdmin.Name = "tabCtrlAdmin";
            this.tabCtrlAdmin.SelectedIndex = 0;
            this.tabCtrlAdmin.Size = new System.Drawing.Size(1076, 470);
            this.tabCtrlAdmin.TabIndex = 6;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.tableLayoutPanel1);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 31);
            this.Rules.Margin = new System.Windows.Forms.Padding(0);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(1068, 435);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mandatoryRulesPane, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAddRule, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.houseRulesPane, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBackHouseRules, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBackMandatoryRules, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.03959F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1060, 427);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // houseRulesPane
            // 
            this.houseRulesPane.AutoScroll = true;
            this.houseRulesPane.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.houseRulesPane.AutoSize = true;
            this.houseRulesPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.houseRulesPane.ColumnCount = 3;
            this.houseRulesPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.houseRulesPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.houseRulesPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.houseRulesPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.houseRulesPane.Location = new System.Drawing.Point(530, 58);
            this.houseRulesPane.Margin = new System.Windows.Forms.Padding(0);
            this.houseRulesPane.Name = "houseRulesPane";
            this.houseRulesPane.RowCount = 1;
            this.houseRulesPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.houseRulesPane.Size = new System.Drawing.Size(530, 310);
            this.houseRulesPane.TabIndex = 0;
            // 
            // pnlBackHouseRules
            // 
            this.pnlBackHouseRules.AutoScroll = true;
            this.pnlBackHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackHouseRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlBackHouseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackHouseRules.Location = new System.Drawing.Point(530, 0);
            this.pnlBackHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackHouseRules.Name = "pnlBackHouseRules";
            this.pnlBackHouseRules.Size = new System.Drawing.Size(530, 58);
            this.pnlBackHouseRules.TabIndex = 2;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Location = new System.Drawing.Point(299, 25);
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
            this.pnlBackMandatoryRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackMandatoryRules.Location = new System.Drawing.Point(0, 0);
            this.pnlBackMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackMandatoryRules.Name = "pnlBackMandatoryRules";
            this.pnlBackMandatoryRules.Size = new System.Drawing.Size(530, 58);
            this.pnlBackMandatoryRules.TabIndex = 1;
            // 
            // lblMandatoryRules
            // 
            this.lblMandatoryRules.AutoSize = true;
            this.lblMandatoryRules.Location = new System.Drawing.Point(95, 25);
            this.lblMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
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
            this.Complaints.Location = new System.Drawing.Point(4, 31);
            this.Complaints.Name = "Complaints";
            this.Complaints.Padding = new System.Windows.Forms.Padding(3);
            this.Complaints.Size = new System.Drawing.Size(1068, 435);
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
            this.pnlBackComplaints.Size = new System.Drawing.Size(1062, 47);
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
            this.btnClearAll.Location = new System.Drawing.Point(699, 388);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(321, 50);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All Complaints";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnClearChecked
            // 
            this.btnClearChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnClearChecked.Location = new System.Drawing.Point(43, 388);
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
            this.pnlComplaints.Size = new System.Drawing.Size(1055, 329);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "House";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctbxBack
            // 
            this.pctbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.ErrorImage")));
            this.pctbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pctbxBack.Image")));
            this.pctbxBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.InitialImage")));
            this.pctbxBack.Location = new System.Drawing.Point(1036, 493);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 7;
            this.pctbxBack.TabStop = false;
            this.pctbxBack.Click += new System.EventHandler(this.PctbxBack_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnAddRule.Location = new System.Drawing.Point(0, 368);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(379, 58);
            this.btnAddRule.TabIndex = 5;
            this.btnAddRule.Text = "Add New Rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mandatory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mandatoryRulesPane
            // 
            this.mandatoryRulesPane.AutoScroll = true;
            this.mandatoryRulesPane.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.mandatoryRulesPane.AutoSize = true;
            this.mandatoryRulesPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mandatoryRulesPane.ColumnCount = 3;
            this.mandatoryRulesPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mandatoryRulesPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mandatoryRulesPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mandatoryRulesPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mandatoryRulesPane.Location = new System.Drawing.Point(0, 58);
            this.mandatoryRulesPane.Margin = new System.Windows.Forms.Padding(0);
            this.mandatoryRulesPane.Name = "mandatoryRulesPane";
            this.mandatoryRulesPane.RowCount = 1;
            this.mandatoryRulesPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mandatoryRulesPane.Size = new System.Drawing.Size(530, 310);
            this.mandatoryRulesPane.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1104, 539);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctbxBack);
            this.Controls.Add(this.tabCtrlAdmin);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.tabCtrlAdmin.ResumeLayout(false);
            this.Rules.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlBackHouseRules.ResumeLayout(false);
            this.pnlBackHouseRules.PerformLayout();
            this.pnlBackMandatoryRules.ResumeLayout(false);
            this.pnlBackMandatoryRules.PerformLayout();
            this.Complaints.ResumeLayout(false);
            this.pnlBackComplaints.ResumeLayout(false);
            this.pnlBackComplaints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtrlAdmin;
        private System.Windows.Forms.TabPage Complaints;
        private System.Windows.Forms.Panel pnlComplaints;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.Panel pnlBackHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlBackMandatoryRules;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.Button btnClearChecked;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel pnlBackComplaints;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Timer timerRules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel houseRulesPane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel mandatoryRulesPane;
    }
}