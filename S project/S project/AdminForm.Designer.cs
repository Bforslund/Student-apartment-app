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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.Complaints = new System.Windows.Forms.TabPage();
            this.tbBackground = new System.Windows.Forms.TableLayoutPanel();
            this.tbComplaints = new System.Windows.Forms.TableLayoutPanel();
            this.pnlComplaints = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.tabCtrlAdmin = new System.Windows.Forms.TabControl();
            this.Rules = new System.Windows.Forms.TabPage();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlHouseRules = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlMandatoryRules = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBackMandatoryRules = new System.Windows.Forms.Panel();
            this.lblMandatoryRules = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.pnlBackHouseRules = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.Complaints.SuspendLayout();
            this.tbBackground.SuspendLayout();
            this.tbComplaints.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabCtrlAdmin.SuspendLayout();
            this.Rules.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlBackMandatoryRules.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBackHouseRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctbxBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 44);
            this.panel1.TabIndex = 0;
            // 
            // pctbxBack
            // 
            this.pctbxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.ErrorImage")));
            this.pctbxBack.Image = ((System.Drawing.Image)(resources.GetObject("pctbxBack.Image")));
            this.pctbxBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctbxBack.InitialImage")));
            this.pctbxBack.Location = new System.Drawing.Point(934, 9);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 11;
            this.pctbxBack.TabStop = false;
            this.pctbxBack.Click += new System.EventHandler(this.PctbxBack_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblHello.Location = new System.Drawing.Point(9, 12);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(146, 24);
            this.lblHello.TabIndex = 12;
            this.lblHello.Text = "Hello, Admin";
            // 
            // Complaints
            // 
            this.Complaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Complaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Complaints.Controls.Add(this.tbBackground);
            this.Complaints.Controls.Add(this.tableLayoutPanel3);
            this.Complaints.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Complaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Complaints.Location = new System.Drawing.Point(4, 32);
            this.Complaints.Margin = new System.Windows.Forms.Padding(0);
            this.Complaints.Name = "Complaints";
            this.Complaints.Size = new System.Drawing.Size(974, 473);
            this.Complaints.TabIndex = 0;
            this.Complaints.Text = "Complaints";
            // 
            // tbBackground
            // 
            this.tbBackground.ColumnCount = 1;
            this.tbBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBackground.Controls.Add(this.tbComplaints, 0, 1);
            this.tbBackground.Controls.Add(this.panel2, 0, 0);
            this.tbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBackground.Location = new System.Drawing.Point(0, 0);
            this.tbBackground.Name = "tbBackground";
            this.tbBackground.RowCount = 2;
            this.tbBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tbBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbBackground.Size = new System.Drawing.Size(972, 407);
            this.tbBackground.TabIndex = 2;
            // 
            // tbComplaints
            // 
            this.tbComplaints.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.tbComplaints.AutoSize = true;
            this.tbComplaints.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbComplaints.ColumnCount = 1;
            this.tbComplaints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbComplaints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbComplaints.Controls.Add(this.pnlComplaints, 0, 0);
            this.tbComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComplaints.Location = new System.Drawing.Point(0, 75);
            this.tbComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.tbComplaints.Name = "tbComplaints";
            this.tbComplaints.RowCount = 1;
            this.tbComplaints.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbComplaints.Size = new System.Drawing.Size(972, 332);
            this.tbComplaints.TabIndex = 2;
            // 
            // pnlComplaints
            // 
            this.pnlComplaints.AutoScroll = true;
            this.pnlComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComplaints.Location = new System.Drawing.Point(0, 0);
            this.pnlComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.pnlComplaints.Name = "pnlComplaints";
            this.pnlComplaints.Size = new System.Drawing.Size(972, 332);
            this.pnlComplaints.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 75);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(430, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Complaints";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveAll, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveSelected, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 407);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(972, 64);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(486, 64);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnRemoveSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.Location = new System.Drawing.Point(486, 0);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(486, 64);
            this.btnRemoveSelected.TabIndex = 7;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // tabCtrlAdmin
            // 
            this.tabCtrlAdmin.Controls.Add(this.Rules);
            this.tabCtrlAdmin.Controls.Add(this.Complaints);
            this.tabCtrlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAdmin.Location = new System.Drawing.Point(0, 44);
            this.tabCtrlAdmin.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tabCtrlAdmin.Name = "tabCtrlAdmin";
            this.tabCtrlAdmin.Padding = new System.Drawing.Point(10, 5);
            this.tabCtrlAdmin.SelectedIndex = 0;
            this.tabCtrlAdmin.Size = new System.Drawing.Size(982, 509);
            this.tabCtrlAdmin.TabIndex = 10;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.tableLayoutPanel1);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 32);
            this.Rules.Margin = new System.Windows.Forms.Padding(0);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(974, 473);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.pnlHouseRules);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(487, 75);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(485, 396);
            this.panel7.TabIndex = 10;
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlHouseRules.AutoSize = true;
            this.pnlHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHouseRules.ColumnCount = 3;
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04848F));
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68711F));
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26441F));
            this.pnlHouseRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHouseRules.Location = new System.Drawing.Point(0, 0);
            this.pnlHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.RowCount = 1;
            this.pnlHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlHouseRules.Size = new System.Drawing.Size(485, 0);
            this.pnlHouseRules.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.btnAddRule);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 396);
            this.panel4.TabIndex = 9;
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRule.Location = new System.Drawing.Point(0, 329);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(484, 67);
            this.btnAddRule.TabIndex = 10;
            this.btnAddRule.Text = "Add New Rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panel6.Controls.Add(this.pnlMandatoryRules);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 329);
            this.panel6.TabIndex = 11;
            // 
            // pnlMandatoryRules
            // 
            this.pnlMandatoryRules.AutoSize = true;
            this.pnlMandatoryRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMandatoryRules.ColumnCount = 3;
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.pnlMandatoryRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMandatoryRules.Location = new System.Drawing.Point(0, 0);
            this.pnlMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMandatoryRules.Name = "pnlMandatoryRules";
            this.pnlMandatoryRules.RowCount = 1;
            this.pnlMandatoryRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMandatoryRules.Size = new System.Drawing.Size(484, 0);
            this.pnlMandatoryRules.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(484, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 75);
            this.panel5.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(484, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 396);
            this.panel3.TabIndex = 7;
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
            this.pnlBackMandatoryRules.Size = new System.Drawing.Size(484, 75);
            this.pnlBackMandatoryRules.TabIndex = 1;
            // 
            // lblMandatoryRules
            // 
            this.lblMandatoryRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMandatoryRules.AutoSize = true;
            this.lblMandatoryRules.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMandatoryRules.Location = new System.Drawing.Point(160, 25);
            this.lblMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.lblMandatoryRules.Name = "lblMandatoryRules";
            this.lblMandatoryRules.Size = new System.Drawing.Size(179, 24);
            this.lblMandatoryRules.TabIndex = 5;
            this.lblMandatoryRules.Text = "Mandatory rules";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.4091653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79542F));
            this.tableLayoutPanel1.Controls.Add(this.pnlBackHouseRules, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBackMandatoryRules, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 471);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblHouseRules
            // 
            this.lblHouseRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHouseRules.AutoSize = true;
            this.lblHouseRules.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHouseRules.Location = new System.Drawing.Point(188, 25);
            this.lblHouseRules.Name = "lblHouseRules";
            this.lblHouseRules.Size = new System.Drawing.Size(134, 24);
            this.lblHouseRules.TabIndex = 6;
            this.lblHouseRules.Text = "House rules";
            // 
            // pnlBackHouseRules
            // 
            this.pnlBackHouseRules.AutoScroll = true;
            this.pnlBackHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackHouseRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlBackHouseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackHouseRules.Location = new System.Drawing.Point(487, 0);
            this.pnlBackHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackHouseRules.Name = "pnlBackHouseRules";
            this.pnlBackHouseRules.Size = new System.Drawing.Size(485, 75);
            this.pnlBackHouseRules.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.tabCtrlAdmin);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.Complaints.ResumeLayout(false);
            this.tbBackground.ResumeLayout(false);
            this.tbBackground.PerformLayout();
            this.tbComplaints.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabCtrlAdmin.ResumeLayout(false);
            this.Rules.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlBackMandatoryRules.ResumeLayout(false);
            this.pnlBackMandatoryRules.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBackHouseRules.ResumeLayout(false);
            this.pnlBackHouseRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.TabPage Complaints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.TabControl tabCtrlAdmin;
        private System.Windows.Forms.TableLayoutPanel tbBackground;
        private System.Windows.Forms.TableLayoutPanel tbComplaints;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Panel pnlComplaints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBackHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlBackMandatoryRules;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel pnlMandatoryRules;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel pnlHouseRules;
    }
}