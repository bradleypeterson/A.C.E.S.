using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RepositoryUrl { get; set; }
        public int AssignmentCode { get; set; }
        public int CourseId { get; set; }
        //public int TotalPoints { get; set; }
    }
}
