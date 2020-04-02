using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Courses.Assignments
{
    public class AssignmentModel : PageModel
    {
        public string CourseName { get; set; }
        public Assignment Assignment { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public AssignmentModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int courseID, int id)
        {
            CourseName = (await _context.Courses
                .Where(c => c.ID == courseID)
                .AsNoTracking()
                .FirstOrDefaultAsync()).Name;
            Assignment = await _context.Assignments
                .Where(a => a.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }
    }
}
