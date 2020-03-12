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
        public Course[] Courses { get; set; }
        public void OnGet()
        {
        }
    }
}
