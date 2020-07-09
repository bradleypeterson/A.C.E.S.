using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Courses
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
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyCourse = new Course();

            if (await TryUpdateModelAsync<Course>(
                emptyCourse,
                "course",   // Prefix for form value.
                s => s.Name, s => s.Archived))
            {
                _context.Courses.Add(emptyCourse);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Courses");
            }

            return Page();
        }
    }
}
