using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Students
{
    public class EditModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public EditModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            student = await _context.Students.FindAsync(id);

            if (student == null)
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

            var studentToUpdate = await _context.Students.FindAsync(id);

            if (studentToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Student>(
                 studentToUpdate,
                 "student",   // Prefix for form value.
                   c => c.Name, c => c.Email, c => c.Standing))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Students");
            }

            return Page();
        }
    }
}
