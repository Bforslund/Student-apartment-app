﻿namespace S_project
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
            this.timerRules = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.tabCtrlAdmin = new System.Windows.Forms.TabControl();
            this.Schedule = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Rules = new System.Windows.Forms.TabPage();
            this.tableLayoutAllRules = new System.Windows.Forms.TableLayoutPanel();
            this.btnComplain = new System.Windows.Forms.Button();
            this.btnProposeRule = new System.Windows.Forms.Button();
            this.pnlBackHouseRules = new System.Windows.Forms.Panel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.pnlBackMandatoryRules = new System.Windows.Forms.Panel();
            this.lblMandatoryRules = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlHouseRules = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlMandatoryRules = new System.Windows.Forms.TableLayoutPanel();
            this.Notifications = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlNotifications = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.tabCtrlAdmin.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Rules.SuspendLayout();
            this.tableLayoutAllRules.SuspendLayout();
            this.pnlBackHouseRules.SuspendLayout();
            this.pnlBackMandatoryRules.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.Notifications.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRules
            // 
            this.timerRules.Enabled = true;
            this.timerRules.Interval = 1000;
            this.timerRules.Tick += new System.EventHandler(this.TimerRules_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdates_Tick);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.button2);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.lblHello);
            this.panelTop.Controls.Add(this.pctbxBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(983, 51);
            this.panelTop.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button2.Location = new System.Drawing.Point(385, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 17;
            this.button2.Text = "Mandatory";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(491, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "House";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHello.Location = new System.Drawing.Point(12, 11);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(219, 24);
            this.lblHello.TabIndex = 18;
            this.lblHello.Text = "Hello, StudentName";
            // 
            // pctbxBack
            // 
            this.pctbxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.ErrorImage")));
            this.pctbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pctbxBack.Image")));
            this.pctbxBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.InitialImage")));
            this.pctbxBack.Location = new System.Drawing.Point(937, 9);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 16;
            this.pctbxBack.TabStop = false;
            // 
            // tabCtrlAdmin
            // 
            this.tabCtrlAdmin.Controls.Add(this.Schedule);
            this.tabCtrlAdmin.Controls.Add(this.Rules);
            this.tabCtrlAdmin.Controls.Add(this.Notifications);
            this.tabCtrlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAdmin.Location = new System.Drawing.Point(0, 51);
            this.tabCtrlAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.tabCtrlAdmin.Name = "tabCtrlAdmin";
            this.tabCtrlAdmin.Padding = new System.Drawing.Point(0, 0);
            this.tabCtrlAdmin.SelectedIndex = 0;
            this.tabCtrlAdmin.Size = new System.Drawing.Size(983, 501);
            this.tabCtrlAdmin.TabIndex = 14;
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Schedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Schedule.Controls.Add(this.tableLayoutPanel2);
            this.Schedule.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Schedule.Location = new System.Drawing.Point(4, 28);
            this.Schedule.Margin = new System.Windows.Forms.Padding(0);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(975, 469);
            this.Schedule.TabIndex = 0;
            this.Schedule.Text = "Schedule";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(973, 467);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.lblSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 60);
            this.panel2.TabIndex = 1;
            // 
            // lblSchedule
            // 
            this.lblSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(438, 23);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(83, 19);
            this.lblSchedule.TabIndex = 6;
            this.lblSchedule.Text = "Schedule";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(973, 407);
            this.panel5.TabIndex = 2;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.tableLayoutAllRules);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 28);
            this.Rules.Margin = new System.Windows.Forms.Padding(0);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(975, 469);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // tableLayoutAllRules
            // 
            this.tableLayoutAllRules.ColumnCount = 3;
            this.tableLayoutAllRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79541F));
            this.tableLayoutAllRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.4091653F));
            this.tableLayoutAllRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79542F));
            this.tableLayoutAllRules.Controls.Add(this.btnComplain, 0, 2);
            this.tableLayoutAllRules.Controls.Add(this.btnProposeRule, 2, 2);
            this.tableLayoutAllRules.Controls.Add(this.pnlBackHouseRules, 2, 0);
            this.tableLayoutAllRules.Controls.Add(this.pnlBackMandatoryRules, 0, 0);
            this.tableLayoutAllRules.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutAllRules.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutAllRules.Controls.Add(this.panel8, 2, 1);
            this.tableLayoutAllRules.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutAllRules.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutAllRules.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutAllRules.Name = "tableLayoutAllRules";
            this.tableLayoutAllRules.RowCount = 3;
            this.tableLayoutAllRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.64027F));
            this.tableLayoutAllRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.05519F));
            this.tableLayoutAllRules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.34879F));
            this.tableLayoutAllRules.Size = new System.Drawing.Size(956, 453);
            this.tableLayoutAllRules.TabIndex = 8;
            // 
            // btnComplain
            // 
            this.btnComplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnComplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplain.Location = new System.Drawing.Point(0, 387);
            this.btnComplain.Margin = new System.Windows.Forms.Padding(0);
            this.btnComplain.Name = "btnComplain";
            this.btnComplain.Size = new System.Drawing.Size(475, 66);
            this.btnComplain.TabIndex = 6;
            this.btnComplain.Text = "File Complaint";
            this.btnComplain.UseVisualStyleBackColor = false;
            this.btnComplain.Click += new System.EventHandler(this.BtnComplain_Click);
            // 
            // btnProposeRule
            // 
            this.btnProposeRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnProposeRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProposeRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProposeRule.Location = new System.Drawing.Point(479, 387);
            this.btnProposeRule.Margin = new System.Windows.Forms.Padding(0);
            this.btnProposeRule.Name = "btnProposeRule";
            this.btnProposeRule.Size = new System.Drawing.Size(477, 66);
            this.btnProposeRule.TabIndex = 5;
            this.btnProposeRule.Text = "Add New Rule";
            this.btnProposeRule.UseVisualStyleBackColor = false;
            this.btnProposeRule.Click += new System.EventHandler(this.BtnProposeRule_Click);
            // 
            // pnlBackHouseRules
            // 
            this.pnlBackHouseRules.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.pnlBackHouseRules.AutoScroll = true;
            this.pnlBackHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackHouseRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlBackHouseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackHouseRules.Location = new System.Drawing.Point(479, 0);
            this.pnlBackHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackHouseRules.Name = "pnlBackHouseRules";
            this.pnlBackHouseRules.Size = new System.Drawing.Size(477, 48);
            this.pnlBackHouseRules.TabIndex = 2;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Location = new System.Drawing.Point(188, 25);
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
            this.pnlBackMandatoryRules.Size = new System.Drawing.Size(476, 48);
            this.pnlBackMandatoryRules.TabIndex = 1;
            // 
            // lblMandatoryRules
            // 
            this.lblMandatoryRules.AutoSize = true;
            this.lblMandatoryRules.Location = new System.Drawing.Point(148, 25);
            this.lblMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.lblMandatoryRules.Name = "lblMandatoryRules";
            this.lblMandatoryRules.Size = new System.Drawing.Size(144, 19);
            this.lblMandatoryRules.TabIndex = 5;
            this.lblMandatoryRules.Text = "Mandatory rules";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.tableLayoutPanel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(476, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 339);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoScroll = true;
            this.tableLayoutPanel6.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41131F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.18195F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.40674F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(3, 339);
            this.tableLayoutPanel6.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(476, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 48);
            this.panel3.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.pnlHouseRules);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(479, 48);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(477, 339);
            this.panel8.TabIndex = 9;
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlHouseRules.AutoSize = true;
            this.pnlHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHouseRules.ColumnCount = 3;
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41131F));
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.18195F));
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.40674F));
            this.pnlHouseRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHouseRules.Location = new System.Drawing.Point(0, 0);
            this.pnlHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.RowCount = 1;
            this.pnlHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlHouseRules.Size = new System.Drawing.Size(477, 0);
            this.pnlHouseRules.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.pnlMandatoryRules);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 48);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(476, 339);
            this.panel6.TabIndex = 10;
            // 
            // pnlMandatoryRules
            // 
            this.pnlMandatoryRules.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlMandatoryRules.AutoSize = true;
            this.pnlMandatoryRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMandatoryRules.ColumnCount = 3;
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41131F));
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.18195F));
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.40674F));
            this.pnlMandatoryRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMandatoryRules.Location = new System.Drawing.Point(0, 0);
            this.pnlMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMandatoryRules.Name = "pnlMandatoryRules";
            this.pnlMandatoryRules.RowCount = 1;
            this.pnlMandatoryRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMandatoryRules.Size = new System.Drawing.Size(476, 0);
            this.pnlMandatoryRules.TabIndex = 7;
            // 
            // Notifications
            // 
            this.Notifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Notifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Notifications.Controls.Add(this.tableLayoutPanel3);
            this.Notifications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Notifications.Location = new System.Drawing.Point(4, 28);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(975, 469);
            this.Notifications.TabIndex = 2;
            this.Notifications.Text = "Notifications";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.04F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(973, 467);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(973, 74);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(430, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Notifications";
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.pnlNotifications);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 74);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(973, 393);
            this.panel7.TabIndex = 2;
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlNotifications.AutoSize = true;
            this.pnlNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNotifications.ColumnCount = 4;
            this.pnlNotifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.85774F));
            this.pnlNotifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.69456F));
            this.pnlNotifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.171548F));
            this.pnlNotifications.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.171548F));
            this.pnlNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNotifications.Location = new System.Drawing.Point(0, 0);
            this.pnlNotifications.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.RowCount = 1;
            this.pnlNotifications.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlNotifications.Size = new System.Drawing.Size(973, 0);
            this.pnlNotifications.TabIndex = 8;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(983, 552);
            this.Controls.Add(this.tabCtrlAdmin);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.tabCtrlAdmin.ResumeLayout(false);
            this.Schedule.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Rules.ResumeLayout(false);
            this.tableLayoutAllRules.ResumeLayout(false);
            this.pnlBackHouseRules.ResumeLayout(false);
            this.pnlBackHouseRules.PerformLayout();
            this.pnlBackMandatoryRules.ResumeLayout(false);
            this.pnlBackMandatoryRules.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.Notifications.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerRules;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.TabControl tabCtrlAdmin;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.TabPage Notifications;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Button btnComplain;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel pnlNotifications;
        private System.Windows.Forms.Button btnProposeRule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAllRules;
        private System.Windows.Forms.Panel pnlBackHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlBackMandatoryRules;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel pnlHouseRules;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel pnlMandatoryRules;
    }
}