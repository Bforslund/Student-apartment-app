using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    //Complaints sent by the students
    public class Complaint
    {
        public int ID { get; set; }
        public string ComplaintText { get; set; }
        public DateTime FiledDate { get; set; }
        public int FiledBy { get; set; } //person's ID
        public int BrokenBy { get; set; } //person's ID
    }

    public class Complaints
    {
        public int HouseNumber { get; set; }
        public List<Complaint> AllComplaints { get; set; }
    }
}
