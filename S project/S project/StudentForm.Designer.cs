namespace S_project
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.tabCtrlStudent = new System.Windows.Forms.TabControl();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.pnlBackSchedule = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.Rules = new System.Windows.Forms.TabPage();
            this.lbxSeparator = new System.Windows.Forms.ListBox();
            this.pnlHouseRules = new System.Windows.Forms.Panel();
            this.lbxHouseRules = new System.Windows.Forms.ListBox();
            this.pnlMandatoryRules = new System.Windows.Forms.Panel();
            this.lbxMandatoryRules = new System.Windows.Forms.ListBox();
            this.btnComplain = new System.Windows.Forms.Button();
            this.btnProposeRule = new System.Windows.Forms.Button();
            this.pnlBackHouseRules = new System.Windows.Forms.Panel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.pnlBackMandatoryRules = new System.Windows.Forms.Panel();
            this.lblMandatoryRules = new System.Windows.Forms.Label();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.timerUpdates = new System.Windows.Forms.Timer(this.components);
            this.timerRules = new System.Windows.Forms.Timer(this.components);
            this.tabCtrlStudent.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.pnlBackSchedule.SuspendLayout();
            this.Rules.SuspendLayout();
            this.pnlHouseRules.SuspendLayout();
            this.pnlMandatoryRules.SuspendLayout();
            this.pnlBackHouseRules.SuspendLayout();
            this.pnlBackMandatoryRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlStudent
            // 
            this.tabCtrlStudent.Controls.Add(this.Schedule);
            this.tabCtrlStudent.Controls.Add(this.Rules);
            this.tabCtrlStudent.Location = new System.Drawing.Point(12, 43);
            this.tabCtrlStudent.Name = "tabCtrlStudent";
            this.tabCtrlStudent.SelectedIndex = 0;
            this.tabCtrlStudent.Size = new System.Drawing.Size(958, 498);
            this.tabCtrlStudent.TabIndex = 0;
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Schedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schedule.Controls.Add(this.pnlBackSchedule);
            this.Schedule.Controls.Add(this.pnlSchedule);
            this.Schedule.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Schedule.Location = new System.Drawing.Point(4, 25);
            this.Schedule.Name = "Schedule";
            this.Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.Schedule.Size = new System.Drawing.Size(950, 469);
            this.Schedule.TabIndex = 0;
            this.Schedule.Text = "Schedule";
            // 
            // pnlBackSchedule
            // 
            this.pnlBackSchedule.AutoScroll = true;
            this.pnlBackSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackSchedule.Controls.Add(this.lblSchedule);
            this.pnlBackSchedule.Location = new System.Drawing.Point(-2, 1);
            this.pnlBackSchedule.Name = "pnlBackSchedule";
            this.pnlBackSchedule.Size = new System.Drawing.Size(955, 47);
            this.pnlBackSchedule.TabIndex = 10;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(433, 17);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(83, 19);
            this.lblSchedule.TabIndex = 5;
            this.lblSchedule.Text = "Schedule";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.AutoScroll = true;
            this.pnlSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSchedule.BackColor = System.Drawing.Color.Transparent;
            this.pnlSchedule.Location = new System.Drawing.Point(6, 54);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(936, 407);
            this.pnlSchedule.TabIndex = 9;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.lbxSeparator);
            this.Rules.Controls.Add(this.pnlHouseRules);
            this.Rules.Controls.Add(this.pnlMandatoryRules);
            this.Rules.Controls.Add(this.btnComplain);
            this.Rules.Controls.Add(this.btnProposeRule);
            this.Rules.Controls.Add(this.pnlBackHouseRules);
            this.Rules.Controls.Add(this.pnlBackMandatoryRules);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 25);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(950, 469);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // lbxSeparator
            // 
            this.lbxSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(118)))), ((int)(((byte)(194)))));
            this.lbxSeparator.FormattingEnabled = true;
            this.lbxSeparator.ItemHeight = 19;
            this.lbxSeparator.Location = new System.Drawing.Point(401, -2);
            this.lbxSeparator.Name = "lbxSeparator";
            this.lbxSeparator.Size = new System.Drawing.Size(10, 479);
            this.lbxSeparator.TabIndex = 3;
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.AutoScroll = true;
            this.pnlHouseRules.Controls.Add(this.lbxHouseRules);
            this.pnlHouseRules.Location = new System.Drawing.Point(417, 53);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.Size = new System.Drawing.Size(525, 363);
            this.pnlHouseRules.TabIndex = 7;
            // 
            // lbxHouseRules
            // 
            this.lbxHouseRules.FormattingEnabled = true;
            this.lbxHouseRules.ItemHeight = 19;
            this.lbxHouseRules.Location = new System.Drawing.Point(16, 17);
            this.lbxHouseRules.Name = "lbxHouseRules";
            this.lbxHouseRules.Size = new System.Drawing.Size(486, 327);
            this.lbxHouseRules.TabIndex = 0;
            // 
            // pnlMandatoryRules
            // 
            this.pnlMandatoryRules.AutoScroll = true;
            this.pnlMandatoryRules.Controls.Add(this.lbxMandatoryRules);
            this.pnlMandatoryRules.Location = new System.Drawing.Point(6, 53);
            this.pnlMandatoryRules.Name = "pnlMandatoryRules";
            this.pnlMandatoryRules.Size = new System.Drawing.Size(389, 363);
            this.pnlMandatoryRules.TabIndex = 6;
            // 
            // lbxMandatoryRules
            // 
            this.lbxMandatoryRules.FormattingEnabled = true;
            this.lbxMandatoryRules.ItemHeight = 19;
            this.lbxMandatoryRules.Location = new System.Drawing.Point(12, 17);
            this.lbxMandatoryRules.Name = "lbxMandatoryRules";
            this.lbxMandatoryRules.Size = new System.Drawing.Size(359, 327);
            this.lbxMandatoryRules.TabIndex = 1;
            // 
            // btnComplain
            // 
            this.btnComplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnComplain.Location = new System.Drawing.Point(-3, 422);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(414, 50);
            this.btnComplain.TabIndex = 5;
            this.btnComplain.Text = "File Complaint";
            this.btnComplain.UseVisualStyleBackColor = false;
            this.btnComplain.Click += new System.EventHandler(this.BtnComplain_Click);
            // 
            // btnProposeRule
            // 
            this.btnProposeRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnProposeRule.Location = new System.Drawing.Point(401, 422);
            this.btnProposeRule.Name = "btnProposeRule";
            this.btnProposeRule.Size = new System.Drawing.Size(552, 50);
            this.btnProposeRule.TabIndex = 4;
            this.btnProposeRule.Text = "Propose New Rule";
            this.btnProposeRule.UseVisualStyleBackColor = false;
            this.btnProposeRule.Click += new System.EventHandler(this.BtnProposeRule_Click);
            // 
            // pnlBackHouseRules
            // 
            this.pnlBackHouseRules.AutoScroll = true;
            this.pnlBackHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackHouseRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlBackHouseRules.Location = new System.Drawing.Point(401, 0);
            this.pnlBackHouseRules.Name = "pnlBackHouseRules";
            this.pnlBackHouseRules.Size = new System.Drawing.Size(552, 47);
            this.pnlBackHouseRules.TabIndex = 2;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Location = new System.Drawing.Point(224, 16);
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
            this.pnlBackMandatoryRules.Location = new System.Drawing.Point(-4, 0);
            this.pnlBackMandatoryRules.Name = "pnlBackMandatoryRules";
            this.pnlBackMandatoryRules.Size = new System.Drawing.Size(415, 47);
            this.pnlBackMandatoryRules.TabIndex = 1;
            // 
            // lblMandatoryRules
            // 
            this.lblMandatoryRules.AutoSize = true;
            this.lblMandatoryRules.Location = new System.Drawing.Point(133, 16);
            this.lblMandatoryRules.Name = "lblMandatoryRules";
            this.lblMandatoryRules.Size = new System.Drawing.Size(144, 19);
            this.lblMandatoryRules.TabIndex = 5;
            this.lblMandatoryRules.Text = "Mandatory rules";
            // 
            // pctbxBack
            // 
            this.pctbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.ErrorImage")));
            this.pctbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pctbxBack.Image")));
            this.pctbxBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.InitialImage")));
            this.pctbxBack.Location = new System.Drawing.Point(934, 16);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 2;
            this.pctbxBack.TabStop = false;
            this.pctbxBack.Click += new System.EventHandler(this.PctbxBack_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHello.Location = new System.Drawing.Point(8, 16);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(219, 24);
            this.lblHello.TabIndex = 5;
            this.lblHello.Text = "Hello, StudentName";
            // 
            // timerUpdates
            // 
            this.timerUpdates.Enabled = true;
            this.timerUpdates.Interval = 500;
            this.timerUpdates.Tick += new System.EventHandler(this.TimerUpdates_Tick);
            // 
            // timerRules
            // 
            this.timerRules.Enabled = true;
            this.timerRules.Interval = 1000;
            this.timerRules.Tick += new System.EventHandler(this.TimerRules_Tick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pctbxBack);
            this.Controls.Add(this.tabCtrlStudent);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "StudentForm";
            this.Text = "5";
            this.tabCtrlStudent.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.pnlBackSchedule.ResumeLayout(false);
            this.pnlBackSchedule.PerformLayout();
            this.Rules.ResumeLayout(false);
            this.pnlHouseRules.ResumeLayout(false);
            this.pnlMandatoryRules.ResumeLayout(false);
            this.pnlBackHouseRules.ResumeLayout(false);
            this.pnlBackHouseRules.PerformLayout();
            this.pnlBackMandatoryRules.ResumeLayout(false);
            this.pnlBackMandatoryRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlStudent;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.Button btnProposeRule;
        private System.Windows.Forms.ListBox lbxSeparator;
        private System.Windows.Forms.Panel pnlBackHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlBackMandatoryRules;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnComplain;
        private System.Windows.Forms.Panel pnlHouseRules;
        private System.Windows.Forms.Panel pnlMandatoryRules;
        private System.Windows.Forms.Panel pnlBackSchedule;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Timer timerUpdates;
        private System.Windows.Forms.ListBox lbxHouseRules;
        private System.Windows.Forms.ListBox lbxMandatoryRules;
        private System.Windows.Forms.Timer timerRules;
    }
}