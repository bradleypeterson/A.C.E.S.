using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Assignments
{
    public class AddModel : PageModel
    {
        public ushort Course;
        public void OnGet(ushort course)
        {
            Course = course;
        }
    }
}
