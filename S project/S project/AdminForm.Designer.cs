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
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearChecked = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerRules = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCtrlAdmin = new System.Windows.Forms.TabControl();
            this.Rules = new System.Windows.Forms.TabPage();
            this.pnlMandatoryRules = new System.Windows.Forms.TableLayoutPanel();
            this.lbxSeparator = new System.Windows.Forms.ListBox();
            this.btnComplain = new System.Windows.Forms.Button();
            this.pnlHouseRulesTop = new System.Windows.Forms.Panel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.pnlMandatoryRulesTop = new System.Windows.Forms.Panel();
            this.lblMandatoryRules = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.pnlBackSchedule = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.lblHello = new System.Windows.Forms.Label();
            this.pnlHouseRules = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.tabCtrlAdmin.SuspendLayout();
            this.Rules.SuspendLayout();
            this.pnlHouseRulesTop.SuspendLayout();
            this.pnlMandatoryRulesTop.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.pnlBackSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnClearAll.Location = new System.Drawing.Point(621, 408);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(321, 50);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All Complaints";
            this.btnClearAll.UseVisualStyleBackColor = false;
            // 
            // btnClearChecked
            // 
            this.btnClearChecked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnClearChecked.Location = new System.Drawing.Point(6, 408);
            this.btnClearChecked.Name = "btnClearChecked";
            this.btnClearChecked.Size = new System.Drawing.Size(321, 50);
            this.btnClearChecked.TabIndex = 6;
            this.btnClearChecked.Text = "Clear Checked Complaints";
            this.btnClearChecked.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(496, 7);
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
            this.pctbxBack.Location = new System.Drawing.Point(934, 16);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 7;
            this.pctbxBack.TabStop = false;
            this.pctbxBack.Click += new System.EventHandler(this.PctbxBack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mandatory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabCtrlAdmin
            // 
            this.tabCtrlAdmin.Controls.Add(this.Rules);
            this.tabCtrlAdmin.Controls.Add(this.Schedule);
            this.tabCtrlAdmin.Location = new System.Drawing.Point(12, 43);
            this.tabCtrlAdmin.Name = "tabCtrlAdmin";
            this.tabCtrlAdmin.SelectedIndex = 0;
            this.tabCtrlAdmin.Size = new System.Drawing.Size(958, 498);
            this.tabCtrlAdmin.TabIndex = 9;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.pnlHouseRules);
            this.Rules.Controls.Add(this.pnlMandatoryRules);
            this.Rules.Controls.Add(this.lbxSeparator);
            this.Rules.Controls.Add(this.btnComplain);
            this.Rules.Controls.Add(this.pnlHouseRulesTop);
            this.Rules.Controls.Add(this.pnlMandatoryRulesTop);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 25);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(950, 469);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // pnlMandatoryRules
            // 
            this.pnlMandatoryRules.AutoScroll = true;
            this.pnlMandatoryRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMandatoryRules.ColumnCount = 3;
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMandatoryRules.Location = new System.Drawing.Point(6, 53);
            this.pnlMandatoryRules.Name = "pnlMandatoryRules";
            this.pnlMandatoryRules.RowCount = 1;
            this.pnlMandatoryRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMandatoryRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 363F));
            this.pnlMandatoryRules.Size = new System.Drawing.Size(389, 363);
            this.pnlMandatoryRules.TabIndex = 0;
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
            // btnComplain
            // 
            this.btnComplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnComplain.Location = new System.Drawing.Point(-3, 422);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(414, 50);
            this.btnComplain.TabIndex = 5;
            this.btnComplain.Text = "Add New Rule";
            this.btnComplain.UseVisualStyleBackColor = false;
            // 
            // pnlHouseRulesTop
            // 
            this.pnlHouseRulesTop.AutoScroll = true;
            this.pnlHouseRulesTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHouseRulesTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlHouseRulesTop.Controls.Add(this.lblHouseRules);
            this.pnlHouseRulesTop.Location = new System.Drawing.Point(401, 0);
            this.pnlHouseRulesTop.Name = "pnlHouseRulesTop";
            this.pnlHouseRulesTop.Size = new System.Drawing.Size(552, 47);
            this.pnlHouseRulesTop.TabIndex = 2;
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
            // pnlMandatoryRulesTop
            // 
            this.pnlMandatoryRulesTop.AutoScroll = true;
            this.pnlMandatoryRulesTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMandatoryRulesTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlMandatoryRulesTop.Controls.Add(this.lblMandatoryRules);
            this.pnlMandatoryRulesTop.Location = new System.Drawing.Point(-4, 0);
            this.pnlMandatoryRulesTop.Name = "pnlMandatoryRulesTop";
            this.pnlMandatoryRulesTop.Size = new System.Drawing.Size(415, 47);
            this.pnlMandatoryRulesTop.TabIndex = 1;
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
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Schedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schedule.Controls.Add(this.pnlBackSchedule);
            this.Schedule.Controls.Add(this.btnClearAll);
            this.Schedule.Controls.Add(this.btnClearChecked);
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
            this.lblSchedule.Size = new System.Drawing.Size(102, 19);
            this.lblSchedule.TabIndex = 5;
            this.lblSchedule.Text = "Complaints";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.AutoScroll = true;
            this.pnlSchedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSchedule.BackColor = System.Drawing.Color.Transparent;
            this.pnlSchedule.Location = new System.Drawing.Point(6, 54);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(936, 348);
            this.pnlSchedule.TabIndex = 9;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHello.Location = new System.Drawing.Point(8, 16);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(146, 24);
            this.lblHello.TabIndex = 10;
            this.lblHello.Text = "Hello, Admin";
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.AutoScroll = true;
            this.pnlHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHouseRules.ColumnCount = 3;
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlHouseRules.Location = new System.Drawing.Point(417, 53);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.RowCount = 1;
            this.pnlHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 363F));
            this.pnlHouseRules.Size = new System.Drawing.Size(525, 408);
            this.pnlHouseRules.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pctbxBack);
            this.Controls.Add(this.tabCtrlAdmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.tabCtrlAdmin.ResumeLayout(false);
            this.Rules.ResumeLayout(false);
            this.pnlHouseRulesTop.ResumeLayout(false);
            this.pnlHouseRulesTop.PerformLayout();
            this.pnlMandatoryRulesTop.ResumeLayout(false);
            this.pnlMandatoryRulesTop.PerformLayout();
            this.Schedule.ResumeLayout(false);
            this.pnlBackSchedule.ResumeLayout(false);
            this.pnlBackSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClearChecked;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Timer timerRules;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabCtrlAdmin;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.Panel pnlBackSchedule;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.ListBox lbxSeparator;
        private System.Windows.Forms.Button btnComplain;
        private System.Windows.Forms.Panel pnlHouseRulesTop;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlMandatoryRulesTop;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TableLayoutPanel pnlMandatoryRules;
        private System.Windows.Forms.TableLayoutPanel pnlHouseRules;
    }
}