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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMandatoryRules = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBackHouseRules = new System.Windows.Forms.Panel();
            this.lblHouseRules = new System.Windows.Forms.Label();
            this.pnlBackMandatoryRules = new System.Windows.Forms.Panel();
            this.lblMandatoryRules = new System.Windows.Forms.Label();
            this.pnlHouseRules = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Complaints = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pctbxBack = new System.Windows.Forms.PictureBox();
            this.lblHello = new System.Windows.Forms.Label();
            this.tabCtrlAdmin.SuspendLayout();
            this.Rules.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBackHouseRules.SuspendLayout();
            this.pnlBackMandatoryRules.SuspendLayout();
            this.Complaints.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlAdmin
            // 
            this.tabCtrlAdmin.Controls.Add(this.Rules);
            this.tabCtrlAdmin.Controls.Add(this.Complaints);
            this.tabCtrlAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.tabCtrlAdmin.Location = new System.Drawing.Point(9, 54);
            this.tabCtrlAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.tabCtrlAdmin.Name = "tabCtrlAdmin";
            this.tabCtrlAdmin.SelectedIndex = 0;
            this.tabCtrlAdmin.Size = new System.Drawing.Size(964, 490);
            this.tabCtrlAdmin.TabIndex = 6;
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Rules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rules.Controls.Add(this.tableLayoutPanel5);
            this.Rules.Controls.Add(this.tableLayoutPanel1);
            this.Rules.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Rules.Location = new System.Drawing.Point(4, 28);
            this.Rules.Margin = new System.Windows.Forms.Padding(0);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(3);
            this.Rules.Size = new System.Drawing.Size(956, 458);
            this.Rules.TabIndex = 1;
            this.Rules.Text = "Rules";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnAddRule, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 392);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(473, 67);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnAddRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRule.Location = new System.Drawing.Point(0, 0);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(473, 67);
            this.btnAddRule.TabIndex = 5;
            this.btnAddRule.Text = "Add New Rule";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.4091653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.79542F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMandatoryRules, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBackHouseRules, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBackMandatoryRules, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlHouseRules, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.03959F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 457);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlMandatoryRules
            // 
            this.pnlMandatoryRules.AutoScroll = true;
            this.pnlMandatoryRules.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlMandatoryRules.AutoSize = true;
            this.pnlMandatoryRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMandatoryRules.ColumnCount = 3;
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5042F));
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.15126F));
            this.pnlMandatoryRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.13445F));
            this.pnlMandatoryRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMandatoryRules.Location = new System.Drawing.Point(0, 72);
            this.pnlMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMandatoryRules.Name = "pnlMandatoryRules";
            this.pnlMandatoryRules.RowCount = 1;
            this.pnlMandatoryRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlMandatoryRules.Size = new System.Drawing.Size(476, 385);
            this.pnlMandatoryRules.TabIndex = 6;
            // 
            // pnlBackHouseRules
            // 
            this.pnlBackHouseRules.AutoScroll = true;
            this.pnlBackHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBackHouseRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlBackHouseRules.Controls.Add(this.lblHouseRules);
            this.pnlBackHouseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackHouseRules.Location = new System.Drawing.Point(479, 0);
            this.pnlBackHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackHouseRules.Name = "pnlBackHouseRules";
            this.pnlBackHouseRules.Size = new System.Drawing.Size(477, 72);
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
            this.pnlBackMandatoryRules.Size = new System.Drawing.Size(476, 72);
            this.pnlBackMandatoryRules.TabIndex = 1;
            // 
            // lblMandatoryRules
            // 
            this.lblMandatoryRules.AutoSize = true;
            this.lblMandatoryRules.Location = new System.Drawing.Point(160, 25);
            this.lblMandatoryRules.Margin = new System.Windows.Forms.Padding(0);
            this.lblMandatoryRules.Name = "lblMandatoryRules";
            this.lblMandatoryRules.Size = new System.Drawing.Size(144, 19);
            this.lblMandatoryRules.TabIndex = 5;
            this.lblMandatoryRules.Text = "Mandatory rules";
            // 
            // pnlHouseRules
            // 
            this.pnlHouseRules.AutoScroll = true;
            this.pnlHouseRules.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnlHouseRules.AutoSize = true;
            this.pnlHouseRules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHouseRules.ColumnCount = 3;
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlHouseRules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlHouseRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHouseRules.Location = new System.Drawing.Point(479, 72);
            this.pnlHouseRules.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHouseRules.Name = "pnlHouseRules";
            this.pnlHouseRules.RowCount = 1;
            this.pnlHouseRules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlHouseRules.Size = new System.Drawing.Size(477, 385);
            this.pnlHouseRules.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(476, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 385);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(476, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 72);
            this.panel3.TabIndex = 8;
            // 
            // Complaints
            // 
            this.Complaints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Complaints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Complaints.Controls.Add(this.tableLayoutPanel3);
            this.Complaints.Controls.Add(this.tableLayoutPanel2);
            this.Complaints.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Complaints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Complaints.Location = new System.Drawing.Point(4, 28);
            this.Complaints.Name = "Complaints";
            this.Complaints.Padding = new System.Windows.Forms.Padding(3);
            this.Complaints.Size = new System.Drawing.Size(956, 458);
            this.Complaints.TabIndex = 0;
            this.Complaints.Text = "Complaints";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveSelected, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRemoveAll, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 389);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(948, 64);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnRemoveSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.Location = new System.Drawing.Point(0, 0);
            this.btnRemoveSelected.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(474, 64);
            this.btnRemoveSelected.TabIndex = 5;
            this.btnRemoveSelected.Text = "Remove All";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnRemoveAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAll.Location = new System.Drawing.Point(474, 0);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(474, 64);
            this.btnRemoveAll.TabIndex = 7;
            this.btnRemoveAll.Text = "Remove Selected";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60784F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.39216F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(956, 390);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(956, 68);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Complaints";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(950, 316);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 35);
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
            this.pctbxBack.Location = new System.Drawing.Point(937, 16);
            this.pctbxBack.Name = "pctbxBack";
            this.pctbxBack.Size = new System.Drawing.Size(36, 32);
            this.pctbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbxBack.TabIndex = 7;
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
            this.lblHello.Size = new System.Drawing.Size(146, 24);
            this.lblHello.TabIndex = 9;
            this.lblHello.Text = "Hello, Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.pctbxBack);
            this.Controls.Add(this.tabCtrlAdmin);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.tabCtrlAdmin.ResumeLayout(false);
            this.Rules.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlBackHouseRules.ResumeLayout(false);
            this.pnlBackHouseRules.PerformLayout();
            this.pnlBackMandatoryRules.ResumeLayout(false);
            this.pnlBackMandatoryRules.PerformLayout();
            this.Complaints.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabCtrlAdmin;
        private System.Windows.Forms.TabPage Complaints;
        private System.Windows.Forms.TabPage Rules;
        private System.Windows.Forms.Panel pnlBackHouseRules;
        private System.Windows.Forms.Label lblHouseRules;
        private System.Windows.Forms.Panel pnlBackMandatoryRules;
        private System.Windows.Forms.Label lblMandatoryRules;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlHouseRules;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctbxBack;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TableLayoutPanel pnlMandatoryRules;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}