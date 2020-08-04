using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public int StudentAssignmentId { get; set; }
        public DateTime DateSubmitted { get; set; }
        /// <summary>
        /// Compared with PointsPossible in Assignment to calculate grade.
        /// </summary>
        public int PointsEarned { get; set; }
    }
}
