using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    //Rules set by tenant
    public class HouseRule
    {
        public int ID { get; set; }
        public string RuleText { get; set; }
        public List<int> OrderOfStudents { get; set; }
        public int CurrentStudent { get; set; }
        public DateTime LastCompleted { get; set; }
        public int Interval { get; set; }
        public bool OnlyThisWeek { get; set; }
        public Dictionary<int, bool> StudentsApproval { get; set; }
        public bool ApprovalState { get; set; }

        public HouseRule()
        {
            this.OrderOfStudents = new List<int>();
            this.StudentsApproval = new Dictionary<int, bool>();
        }

    }

    public class HouseRules
    {
        public int HouseNumber { get; set; }
        public List<HouseRule> AllRules { get; set; }

        public HouseRules Clone()
        {
            return (HouseRules)this.MemberwiseClone();
        }
    }
}
