using System;

namespace A.C.E.S.Models
{
    public class Commit
    {
        public int Id { get; set; }
        public int StudentAssignmentId { get; set; }
        public DateTime DateCommitted { get; set; }
        public int LinesAdded { get; set; }
        public int LinesDeleted { get; set; }
    }
}
