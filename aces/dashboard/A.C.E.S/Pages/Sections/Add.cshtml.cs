using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Sections
{
    public class AddModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public AddModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Section Section { get; set; }

        //On submit, create new section, fill with user data, then commit to database
        public async Task<IActionResult> OnPostAsync()
        {
            var emptySection = new Section();

            if (await TryUpdateModelAsync<Section>(
                emptySection,
                "section",   // Prefix for form value.
                s => s.Name, s => s.Students, s => s.Semester, s => s.Name, s => s.Year, s => s.CourseID, s => s.Archived))
            {
                _context.Sections.Add(emptySection);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Sections");
            }

            return Page();
        }
    }
}
