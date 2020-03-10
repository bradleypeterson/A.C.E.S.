using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages
{
    public class StudentsModel : PageModel
    {
        public List<string> students { get; set; }
        public void OnGet()
        {
            students = new List<string>();
            students.Add("Joseph Hwang");
            students.Add("John Doe");
        }
    }
}
