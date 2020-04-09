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
        public List<List<Assignment>> Assignments { get; set; }
        public List<List<Section>> Sections { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .AsNoTracking()
                .ToListAsync();
            Assignments = new List<List<Assignment>>();
            Sections = new List<List<Section>>();

            foreach (var course in Courses)
            {
                var assignments = await _context.Assignments
                    .Where(a => a.CourseID == course.ID)
                    .AsNoTracking()
                    .ToListAsync();
                Assignments.Add(assignments);

                var sections = await _context.Sections
                    .Where(s => s.CourseID == course.ID)
                    .AsNoTracking()
                    .ToListAsync();
                Sections.Add(sections);
            }
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            return new JsonResult(true);
        }
    }
}
