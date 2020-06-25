using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    /// <summary>
    /// Student Section base class used to assoiciate a student with 
    /// a given section
    /// </summary>
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
