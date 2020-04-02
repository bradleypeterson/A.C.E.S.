using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class Submission
    {
        public int ID { get; set; }
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
        public int Grade { get; set; }
        public Standing Standing { get; set; }
        public DateTime DateTime { get; set; }
    }
}
