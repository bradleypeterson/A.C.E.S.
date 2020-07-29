using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models.ViewModels
{
    public class AssignmentStudentsVM
    {
        public int AssignmentId { get; set; }
        public string AssignmentName { get; set; }
        public List<StudentAssignment> StudentAssignments { get; set; }
    }
}
