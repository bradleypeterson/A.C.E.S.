using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class Course
    {
        public ushort ID { get; set; }
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; }
        public bool Archived { get; set; }

        public Course(ushort id, string name)
        {
            ID = id;
            Name = name;
            Assignments = new List<Assignment>();
        }
    }
}
