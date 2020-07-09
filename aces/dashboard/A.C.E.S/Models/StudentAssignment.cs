using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class StudentAssignment
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int AssignmentID { get; set; }
        public Standing AverageStanding { get; set; }
        public Standing OverrideStanding { get; set; }
    }
}
