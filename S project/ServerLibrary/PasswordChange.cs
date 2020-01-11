using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    public class PasswordChange
    {
        public int ID { get; set; }
        public string NewPassword { get; set; }
        public string CurrentPassword { get; set; }
        public int HouseNumber { get; set; }

        public PasswordChange(int id, string newPassword, string currentPassword, int houseNumber)
        {
            this.ID = id;
            this.NewPassword = newPassword;
            this.CurrentPassword = currentPassword;
            this.HouseNumber = houseNumber;
        }
    }
}
