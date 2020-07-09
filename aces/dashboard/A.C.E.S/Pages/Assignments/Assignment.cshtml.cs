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

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments.FindAsync(id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assignmentToUpdate = await _context.Assignments.FindAsync(id);

            if (assignmentToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Assignment>(
                 assignmentToUpdate,
                 "assignment",   // Prefix for form value.
                 a => a.Name, a => a.RepositoryUrl, a => a.AssignmentCode, a => a.CourseId)) // IS WHAT IT SHOULD BE
                 //a => a.Name, a => a.RepositoryUrl, a => a.CourseId))

            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Courses");
            }

            return Page();
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            var assignment = _context.Assignments.Find(id);

            if (assignment == null)
            {
                return new JsonResult(false);
            }

            if (_context.SaveChanges() == 0)
                return new JsonResult(false);

            return new JsonResult(true);
        }
    }
}
