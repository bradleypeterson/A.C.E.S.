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

        public JsonResult OnGetArchive(int id, bool archive)
        {
            var section = _context.Sections.Find(id);

            if (section == null)
            {
                return new JsonResult(false);
            }

            section.Archived = archive;
            if (_context.SaveChanges() == 0)
                return new JsonResult(false);

            return new JsonResult(true);
        }
    }
}
