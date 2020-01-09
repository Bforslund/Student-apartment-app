using System;
using System.Collections.Generic;
using System.Text;

namespace ServerLibrary
{
    public class ChatMessage
    {
        public DateTime FiledDate { get; set; }
        public int FiledBy { get; set; } //person's ID

        public string MessageText { get; set; }
    }
    public class ChatHistory
    {
        public int HouseNumber { get; set; }
        public List<ChatMessage> AllMessages { get; set; }
    }
}
