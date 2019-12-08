using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_project
{
    //Class that keeps track of all students' information
    public class Student : HouseNumber
    {
        private string firstName;
        private string lastName;
        private int roomNumber;
        private string username;
        private string password;

        public Student(string firstName, string lastName, int roomNumber, string username, string password, int houseNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.roomNumber = roomNumber;
            this.username = username;
            this.password = password;
            this.houseNumber = houseNumber;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string GetLastName()
        {
            return this.lastName;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public int GetRoomNumber()
        {
            return this.roomNumber;
        }
        public void SetRoomNumber(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        public string GetUsername()
        {
            return this.username;
        }
        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public override int GetHouseNumber()
        {
            return this.houseNumber;
        }
        public override void SetHouseNumber(int houseNumber)
        {
            this.houseNumber = houseNumber;
        }
    }
}
