using Newtonsoft.Json;
using System;

namespace ClassLibrary
{
    public class Student
    {
        [JsonProperty]
        private int id;

        public Student(int id)
        {
            this.id = id;
        }
    }
}
