using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models.ViewModels
{
    public class AssignmentStudentSubmissionsVM
    {
        public int StudentAssignmentId { get; set; }
        public string StudentName { get; set; }
        public string AssignmentName { get; set; }
        public List<Submission> Submissions { get; set; }
    }
}
