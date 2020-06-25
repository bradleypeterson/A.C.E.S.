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
        public List<Assignment> Assignments { get; set; }

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
            Assignments = await _context.Assignments
                .Where(a => a.CourseID == Course.ID)
                .AsNoTracking()
                .ToListAsync();
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            var assignment = _context.Assignments.Find(id);

            if (assignment == null)
            {
                return new JsonResult(false);
            }

            assignment.Archived = archive;
            if (_context.SaveChanges() == 0)
                return new JsonResult(false);

            return new JsonResult(true);
        }
    }
}
