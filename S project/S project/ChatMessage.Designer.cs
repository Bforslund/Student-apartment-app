namespace S_project
{
    partial class ucChatMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTime = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(21, 40);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(46, 17);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "label1";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(18, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 24);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "label1";
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Enabled = false;
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.Location = new System.Drawing.Point(157, 13);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(5);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbMessage.Size = new System.Drawing.Size(443, 40);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.Text = "dddddddddddddddddddddddddddddddddddddddddddddddddddddddddd";
            this.tbMessage.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rchContents_ContentsResized);
            // 
            // ucChatMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTime);
            this.Name = "ucChatMessage";
            this.Size = new System.Drawing.Size(711, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.RichTextBox tbMessage;
    }
}
