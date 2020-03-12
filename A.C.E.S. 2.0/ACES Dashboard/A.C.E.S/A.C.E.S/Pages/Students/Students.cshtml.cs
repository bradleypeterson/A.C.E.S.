using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A.C.E.S.Models;

namespace A.C.E.S.Pages.Students
{
    public class StudentsModel : PageModel
    {
        public List<Student> students { get; set; }
        public void OnGet()
        {
            students = new List<Student>();
            students.Add(new Student(10000, "josephhwang@mail.weber.edu", "Joseph Hwang", Status.Good));
            students.Add(new Student(10001, "johndoe@mail.weber.edu", "John Doe", Status.Moderate));
            students.Add(new Student(10002, "janedoe@mail.weber.edu", "Jane Doe", Status.Bad));
            students.Add(new Student(10003, "oldstudent@mail.weber.edu", "Old Student", Status.Good));
            students[3].Archived = true;
        }
    }
}
