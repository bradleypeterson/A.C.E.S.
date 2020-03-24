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
        [BindProperty(SupportsGet = true)]
        public ushort ID { get; set; }

        public Student student { get; set; }
        public void OnGet()
        {
            student = new Student(ID, "josephhwang@mail.weber.edu", "Joseph Hwang", Standing.Good);
        }
    }
}
