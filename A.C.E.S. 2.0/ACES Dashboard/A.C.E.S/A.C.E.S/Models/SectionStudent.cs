using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class SectionStudent
    {
        [Key]
        public int ID { get; set; }
        public int SectionID { get; set; }
        public int StudentID { get; set; }

        public virtual Section Section { get; set; }
        public virtual Student Student { get; set; }
    }
}
