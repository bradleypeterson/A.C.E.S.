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
    public class EditModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public EditModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Section Section { get; set; }

        //Get the given section from the database
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Section = await _context.Sections.FindAsync(id);

            if (Section == null)
            {
                return NotFound();
            }
            return Page();
        }

        //On submit, find the section, assign new user values, and commit to database
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sectionToUpdate = await _context.Sections.FindAsync(id);

            if (sectionToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Section>(
                 sectionToUpdate,
                 "section",   // Prefix for form value.
                   s => s.Name, s => s.Semester, s => s.Year, s => s.Length))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Sections");
            }

            return Page();
        }
    }
}
