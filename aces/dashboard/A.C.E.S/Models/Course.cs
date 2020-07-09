using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.C.E.S.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
