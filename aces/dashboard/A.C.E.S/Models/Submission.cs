using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    /// <summary>
    /// Submission base class with all of its atributes.
    /// Entry Created for each time the student Submits assignment
    /// </summary>
    public class Submission
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int AssignmentID { get; set; }
        public Assignment Assignment { get; set; }
        public int Grade { get; set; }
        public Standing Standing { get; set; }
        public DateTime DateTime { get; set; }
    }
}
