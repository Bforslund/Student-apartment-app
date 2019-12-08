using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_project
{
    //Class that keeps track of all House rules
    public class StudentRule : Rule
    {
        private int repeating;

        public StudentRule(string name, int repeating, int houseNumber)
        {
            this.name = name;
            this.repeating = repeating;
            this.houseNumber = houseNumber;
        }
        public override string GetName()
        {
            return this.name;
        }
        public override void SetName(string name)
        {
            this.name = name;
        }
        public int GetRepeating()
        {
            return this.repeating;
        }
        public void SetRepeating(int repeating)
        {
            this.repeating = repeating;
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
