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
        }
    }
}
