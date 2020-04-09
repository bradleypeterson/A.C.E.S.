using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A.C.E.S.Data;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Courses
{
    public class CoursesModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public CoursesModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .AsNoTracking()
                .ToListAsync();
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            return new JsonResult(true);
        }
    }
}
