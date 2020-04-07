using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Courses
{
    public class CourseModel : PageModel
    {
        public Course Course { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public CourseModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            Course = await _context.Courses
                .Where(c => c.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            Course.Assignments = await _context.Assignments
                .Where(a => a.CourseID == Course.ID)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
