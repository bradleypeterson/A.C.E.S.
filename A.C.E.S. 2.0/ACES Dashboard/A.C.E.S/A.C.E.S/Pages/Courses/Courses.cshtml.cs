using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Courses
{
    public class CoursesModel : PageModel
    {
        public List<Course> Courses { get; set; }
        public void OnGet()
        {
            Courses = new List<Course>();
            Courses.Add(new Course(10000, "CS 1040"));
            Courses.Add(new Course(10001, "CS 1035"));
            Courses[1].Archived = true;
            Courses[0].Assignments.Add(new Assignment(1000, "Assignment 1"));
            Courses[0].Assignments.Add(new Assignment(1001, "Assignment 2"));
            Courses[0].Assignments.Add(new Assignment(1002, "Assignment 3"));
        }
    }
}
