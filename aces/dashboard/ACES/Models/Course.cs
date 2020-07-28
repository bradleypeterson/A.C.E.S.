using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models
{
    public class Course
    {
        public int Id { get; set; }
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [DisplayName("Instructor ID")]
        public int InstructorId { get; set; }
    }
}
