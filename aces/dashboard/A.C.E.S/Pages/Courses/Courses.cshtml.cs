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
        private readonly ACESContext _context;

        public CoursesModel(ACESContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }
        public List<List<Assignment>> Assignments { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .AsNoTracking()
                .ToListAsync();
            Assignments = new List<List<Assignment>>();

            foreach (var course in Courses)
            {
                var assignments = await _context.Assignments
                    .Where(a => a.Id == course.Id)
                    .AsNoTracking()
                    .ToListAsync();
                Assignments.Add(assignments);
            }
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            var course = _context.Courses.Find(id);

            if (course == null)
            {
                return new JsonResult(false);
            }

            if (_context.SaveChanges() == 0)
                return new JsonResult(false);

            return new JsonResult(true);
        }
    }
}
