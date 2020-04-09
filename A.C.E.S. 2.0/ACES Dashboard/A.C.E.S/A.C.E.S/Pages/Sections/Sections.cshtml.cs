using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Sections
{
    public class SectionsModel : PageModel
    {
        public List<Section> Sections { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public SectionsModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Sections = await _context.Sections
                .AsNoTracking()
                .ToListAsync();
            foreach (var section in Sections)
            {
                section.Course = await _context.Courses
                    .Where(c => c.ID == section.CourseID)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<IActionResult> OnPostArchive(int cartId)
        {
            var sectionToUpdate = await _context.Sections.FindAsync(cartId);

            if (sectionToUpdate == null)
            {
                return NotFound();
            }

            sectionToUpdate.Archived = true;
            await _context.SaveChangesAsync();
            return RedirectToPage("./Sections");
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            

            return new JsonResult(true);
        }
    }
}
