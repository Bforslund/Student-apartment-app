using System;
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
        //List containing all mandatory rules (can be modified to enter mandatory rules for specific houses only)
        public static List<MandatoryRule> mandatoryRules = new List<MandatoryRule>();

        //List containing all the rules made by students from all houses
        public static List<StudentRule> studentRules = new List<StudentRule>();

        //List containing all the students from all houses
        public static List<Student> studentsList = new List<Student>();

        public static bool readOnce = false;

        public Login()
        {
            InitializeComponent();
            //Convert the displayed characters in the password textbox to *
            tbxPassword.PasswordChar = '*';

            //Dummy data
            if (readOnce == false)
            {
                mandatoryRules.Add(new MandatoryRule("No smoking"));
                mandatoryRules.Add(new MandatoryRule("No pets allowed"));

                studentsList.Add(new Student("Mike", "Myers", 1, "student11", "deeznuts", 1));
                studentsList.Add(new Student("Bob", "Marley", 2, "student12", "deeznuts", 1));
                readOnce = true;
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //Initialize the type of user to unknown
            string type = "Unknown";
            //The integer that will be used to show which student from the list logged in (if the user is a student)
            int studentNumber = 0;

            //If the user is the admin (username: admin, password: admin)
            if(tbxUsername.Text == "admin" && tbxPassword.Text == "admin")
            {
                type = "Admin";
            }
            else
            {
                //Search in the list of students for the username and password
                for(int i = 0; i < studentsList.Count; i++)
                {
                    if(studentsList[i].GetUsername() == tbxUsername.Text && studentsList[i].GetPassword() == tbxPassword.Text)
                    {
                        //If the username and password belong to a student, log in as that student
                        type = "Student";
                        studentNumber = i;
                        break;
                    }
                }
            }
            if (cbxHouseNumber.SelectedItem != null)
            {
                //if a house number has been selected
                int houseNumber = Convert.ToInt32(cbxHouseNumber.Text);
                if (houseNumber < 3)
                {
                    //Log in based on type
                    switch (type)
                    {
                        case "Admin":
                            AdminForm adminForm = new AdminForm(houseNumber);
                            adminForm.Show();
                            this.Hide();
                            break;

                        case "Student":
                            StudentForm studentForm = new StudentForm(studentsList[studentNumber]);
                            studentForm.Show();
                            this.Hide();
                            break;

                        default:
                            MessageBox.Show("Wrong username, password or house number");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("This house does not exist");
                }
            }
            else
            {
                MessageBox.Show("Please select a house number");
            }
        }
    }
}
