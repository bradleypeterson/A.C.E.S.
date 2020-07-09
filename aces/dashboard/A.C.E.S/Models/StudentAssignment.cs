using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    /// <summary>
    /// This class links an assignment to a particular student
    /// </summary>
    public class StudentAssignment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public Guid Watermaker { get; set; }
        public string RepositoryUrl { get; set; }
        public List<Submission> Submissions { get; set; }
        public List<Commit> Commits { get; set; }
    }
}
