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
            students.Add(new Student());
            students[0].ID = 1000;
            students[0].Name = "John Doe";
            students[0].Email = "johndoe@school.edu";
            students[0].Standing = Standing.Good;
            students[0].Archived = false;
        }
    }
}
