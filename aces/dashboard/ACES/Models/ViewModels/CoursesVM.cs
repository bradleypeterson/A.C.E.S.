using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACES.Models.ViewModels
{
    public class CoursesVM
    {
        public Instructor Instructor { get; set; }
        public List<Course> Courses { get; set; }
    }
}
