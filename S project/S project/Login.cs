﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_project
{
    public partial class Login : Form
    {
        ServerConnection serverConnection = new ServerConnection();

       
        //List containing all the rules made by students from all houses
        public static List<StudentRule> studentRules = new List<StudentRule>();

        public Login()
        {
            InitializeComponent();
            //Convert the displayed characters in the password textbox to *
            tbPassword.PasswordChar = '*';            
        }

        private void bShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '\0';
        }

        private void bShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            CheckUser();
        }

        private void CheckUser()
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            int houseNumber = Convert.ToInt32(cbHouseNumber.Text);

            UserInfo u = serverConnection.CheckUser(login, password, houseNumber);

            if (u == null)
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (u.Type)
            {
                case UserType.EMPLOYEE:
                    AdminForm adminForm = new AdminForm(serverConnection, u.HouseNumber);
                    adminForm.Show();
                    this.Hide();
                    break;

                case UserType.TENANT:
                    Student st = new Student(u.Name, u.Name, u.Room, "NA", "NA", u.HouseNumber);

                    StudentForm studentForm = new StudentForm(st);
                    studentForm.Show();
                    this.Hide();
                    break;

                default:
                    MessageBox.Show("Wrong username, password or house number");
                    break;
            }

            bSignIn.Enabled = true;
            tbLogin.Text = "";
            tbPassword.Text = "";
        }
    }
}
