using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ServerLibrary;

namespace S_project
{
    public partial class Login : Form
    {
        ServerConnection serverConnection = new ServerConnection();

        public Login()
        {
            InitializeComponent();
            //Convert the displayed characters in the password textbox to *
            tbPassword.PasswordChar = '*';
            cbHouseNumber.SelectedItem = cbHouseNumber.Items[0];
        }

        private void bShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            //When is pressed show the password
            tbPassword.PasswordChar = '\0';
        }

        private void bShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            //When is released password is hidden one more time
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
            //Reads the credentials
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            int houseNumber = Convert.ToInt32(cbHouseNumber.Text);

            //Sends data to the server
            UserInfo u = serverConnection.CheckUser(login, password, houseNumber);

            //Handles received answer from the server 
            if (u == null)
            {
                MessageBox.Show("Invalid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bSignIn.Enabled = true;
                return;
            }

            switch (u.Type)
            {
                case UserType.EMPLOYEE:
                    AdminForm adminForm = new AdminForm(serverConnection, u.HouseNumber, u);
                    adminForm.Show();
                    this.Hide();
                    break;

                case UserType.TENANT:
                    StudentForm studentForm = new StudentForm(serverConnection, u);
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
