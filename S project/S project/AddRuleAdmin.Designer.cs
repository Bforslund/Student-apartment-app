namespace S_project
{
    partial class AddRuleAdmin
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
            this.pnlNewRule = new System.Windows.Forms.Panel();
            this.lblNewRule = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxRuleName = new System.Windows.Forms.TextBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.pnlNewRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewRule
            // 
            this.pnlNewRule.AutoScroll = true;
            this.pnlNewRule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNewRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlNewRule.Controls.Add(this.lblNewRule);
            this.pnlNewRule.Location = new System.Drawing.Point(-1, -1);
            this.pnlNewRule.Name = "pnlNewRule";
            this.pnlNewRule.Size = new System.Drawing.Size(386, 55);
            this.pnlNewRule.TabIndex = 21;
            // 
            // lblNewRule
            // 
            this.lblNewRule.AutoSize = true;
            this.lblNewRule.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewRule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNewRule.Location = new System.Drawing.Point(157, 21);
            this.lblNewRule.Name = "lblNewRule";
            this.lblNewRule.Size = new System.Drawing.Size(86, 19);
            this.lblNewRule.TabIndex = 5;
            this.lblNewRule.Text = "New Rule";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblName.Location = new System.Drawing.Point(8, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 19);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name:";
            // 
            // tbxRuleName
            // 
            this.tbxRuleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbxRuleName.Location = new System.Drawing.Point(12, 96);
            this.tbxRuleName.Name = "tbxRuleName";
            this.tbxRuleName.Size = new System.Drawing.Size(358, 22);
            this.tbxRuleName.TabIndex = 19;
            // 
            // btnAddRule
            // 
            this.btnAddRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnAddRule.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddRule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddRule.Location = new System.Drawing.Point(223, 243);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(147, 58);
            this.btnAddRule.TabIndex = 29;
            this.btnAddRule.Text = "Add to Rules";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.BtnAddRule_Click);
            // 
            // AddRuleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.pnlNewRule);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxRuleName);
            this.Controls.Add(this.btnAddRule);
            this.Name = "AddRuleAdmin";
            this.Text = "Add New Rule";
            this.pnlNewRule.ResumeLayout(false);
            this.pnlNewRule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewRule;
        private System.Windows.Forms.Label lblNewRule;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxRuleName;
        private System.Windows.Forms.Button btnAddRule;
    }
}