using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.APIs
{
    public class StudentModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public StudentModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public JsonResult OnGetArchive()
        {
            return new JsonResult(true);
        }
    }
}
