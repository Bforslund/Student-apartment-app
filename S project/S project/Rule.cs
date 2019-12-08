using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_project
{
    //Abstract class for Mandatory and House rules
    public abstract class Rule : HouseNumber
    {
        protected string name;

        public abstract string GetName();
        public abstract void SetName(string name);
    }
}
