using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Students
{
    public class StudentModel : PageModel
    {
        public Student student { get; set; }
        public void OnGet(int ID)
        {
            student = new Student();
            student.ID = ID;
            student.Name = "John Doe";
            student.Email = "johndoe@school.edu";
            student.Standing = Standing.Good;
            student.Archived = false;
        }
    }
}
