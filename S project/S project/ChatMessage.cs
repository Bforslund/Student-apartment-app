﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_project
{
    public partial class ucChatMessage : UserControl
    {
        //Constructor fills in received information in the user control
        public ucChatMessage(string message, string time, string name)
        {
            InitializeComponent();
            tbMessage.Text = message;
            lbTime.Text = time;
            lbName.Text = name;

            tbMessage.SelectAll();
            tbMessage.SelectionColor = Color.Black;
        }

        //Resizes user control so that it could fit all the text
        private void rchContents_ContentsResized(object sender,
        ContentsResizedEventArgs e)
        {
            const int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
            this.Height += e.NewRectangle.Height;
        }
    }
}
