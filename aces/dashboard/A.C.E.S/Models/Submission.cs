using System;

namespace A.C.E.S.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public int StudentAssignmentId { get; set; }
        public DateTime DateSubmitted { get; set; }
        public float Grade { get; set; }
    }
}
