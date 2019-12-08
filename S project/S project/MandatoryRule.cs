using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_project
{
    //Class that keeps track of all Mandatory rules
    public class MandatoryRule : Rule
    {
        public MandatoryRule(string name)
        {
            this.name = name;
        }
        public override string GetName()
        {
            return this.name;
        }
        public override void SetName(string name)
        {
            this.name = name;
        }
        public override int GetHouseNumber()
        {
            throw new NotImplementedException();
        }
        public override void SetHouseNumber(int houseNumber)
        {
            throw new NotImplementedException();
        }
    }
}
