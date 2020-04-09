using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Sections
{
    public class SectionModel : PageModel
    {
        public Section Section { get; set; }
        public List<Student> Students { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public SectionModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            Section = await _context.Sections
                .Where(s => s.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            Section.Course = await _context.Courses
                .Where(c => c.ID == Section.CourseID)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            var sectionStudents = await _context.SectionStudents
                .Where(s => s.SectionID == Section.ID)
                .AsNoTracking()
                .ToListAsync();
            Students = await _context.Students
                .AsNoTracking()
                .ToListAsync();
        }

        public JsonResult OnGetEnroll(int id, bool enroll)
        {
            return new JsonResult(true);
        }
    }
}
