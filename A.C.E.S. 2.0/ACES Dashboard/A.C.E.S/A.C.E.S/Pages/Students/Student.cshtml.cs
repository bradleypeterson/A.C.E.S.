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
            //student = new Student(ID, "josephhwang@mail.weber.edu", "Joseph Hwang", Standing.Good);
        }
    }
}
