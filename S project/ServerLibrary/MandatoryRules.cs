using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    //Rules set by the company
    public class MandatoryRule
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
    }

    public class MandatoryRules
    {
        public int HouseNumber { get; set; }
        public List<MandatoryRule> AllRules { get; set; }
    }
}
