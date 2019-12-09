using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_project
{
    //Abstract class for the house number of all House Rules, Students and Mandatory Rules
    public abstract class HouseNumber
    {
        protected int houseNumber;

        public abstract int GetHouseNumber(); 

        public abstract void SetHouseNumber(int houseNumber);
    }
}
