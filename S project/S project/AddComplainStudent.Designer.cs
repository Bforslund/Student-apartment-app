namespace S_project
{
    partial class AddComplainStudent
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
            this.pnlNewComplaint = new System.Windows.Forms.Panel();
            this.lblNewComplaint = new System.Windows.Forms.Label();
            this.lblRuleBroken = new System.Windows.Forms.Label();
            this.btnAddComplaint = new System.Windows.Forms.Button();
            this.cbxRuleBroken = new System.Windows.Forms.ComboBox();
            this.cbxName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlNewComplaint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNewComplaint
            // 
            this.pnlNewComplaint.AutoScroll = true;
            this.pnlNewComplaint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNewComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(177)))), ((int)(((byte)(241)))));
            this.pnlNewComplaint.Controls.Add(this.lblNewComplaint);
            this.pnlNewComplaint.Location = new System.Drawing.Point(-1, -1);
            this.pnlNewComplaint.Name = "pnlNewComplaint";
            this.pnlNewComplaint.Size = new System.Drawing.Size(386, 55);
            this.pnlNewComplaint.TabIndex = 21;
            // 
            // lblNewComplaint
            // 
            this.lblNewComplaint.AutoSize = true;
            this.lblNewComplaint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNewComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNewComplaint.Location = new System.Drawing.Point(141, 21);
            this.lblNewComplaint.Name = "lblNewComplaint";
            this.lblNewComplaint.Size = new System.Drawing.Size(127, 19);
            this.lblNewComplaint.TabIndex = 5;
            this.lblNewComplaint.Text = "File Complaint";
            // 
            // lblRuleBroken
            // 
            this.lblRuleBroken.AutoSize = true;
            this.lblRuleBroken.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleBroken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblRuleBroken.Location = new System.Drawing.Point(8, 74);
            this.lblRuleBroken.Name = "lblRuleBroken";
            this.lblRuleBroken.Size = new System.Drawing.Size(117, 19);
            this.lblRuleBroken.TabIndex = 20;
            this.lblRuleBroken.Text = "Rule Broken:";
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(202)))), ((int)(((byte)(241)))));
            this.btnAddComplaint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddComplaint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddComplaint.Location = new System.Drawing.Point(223, 243);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(147, 58);
            this.btnAddComplaint.TabIndex = 29;
            this.btnAddComplaint.Text = "Add to Complaints";
            this.btnAddComplaint.UseVisualStyleBackColor = false;
            this.btnAddComplaint.Click += new System.EventHandler(this.BtnAddComplaint_Click);
            // 
            // cbxRuleBroken
            // 
            this.cbxRuleBroken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbxRuleBroken.FormattingEnabled = true;
            this.cbxRuleBroken.Location = new System.Drawing.Point(12, 96);
            this.cbxRuleBroken.Name = "cbxRuleBroken";
            this.cbxRuleBroken.Size = new System.Drawing.Size(358, 24);
            this.cbxRuleBroken.TabIndex = 30;
            // 
            // cbxName
            // 
            this.cbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbxName.FormattingEnabled = true;
            this.cbxName.Location = new System.Drawing.Point(12, 170);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(358, 24);
            this.cbxName.TabIndex = 31;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblName.Location = new System.Drawing.Point(8, 148);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 19);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "By:";
            // 
            // AddComplainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.cbxRuleBroken);
            this.Controls.Add(this.pnlNewComplaint);
            this.Controls.Add(this.lblRuleBroken);
            this.Controls.Add(this.btnAddComplaint);
            this.Name = "AddComplainStudent";
            this.Text = "File Complaint";
            this.pnlNewComplaint.ResumeLayout(false);
            this.pnlNewComplaint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewComplaint;
        private System.Windows.Forms.Label lblNewComplaint;
        private System.Windows.Forms.Label lblRuleBroken;
        private System.Windows.Forms.Button btnAddComplaint;
        private System.Windows.Forms.ComboBox cbxRuleBroken;
        private System.Windows.Forms.ComboBox cbxName;
        private System.Windows.Forms.Label lblName;
    }
}