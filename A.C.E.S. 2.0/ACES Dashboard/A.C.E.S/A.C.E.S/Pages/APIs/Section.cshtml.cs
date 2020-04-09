using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.APIs
{
    public class SectionModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public SectionModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }
        public JsonResult OnGetGet(int id)
        {
            var section = _context.Sections.FirstOrDefault(s => s.ID == id);
            section.Course = _context.Courses.FirstOrDefault(c => c.ID == section.CourseID);

            return new JsonResult(section);
        }
        public JsonResult OnGetArchive(int id, bool archive)
        {
            return new JsonResult(true);
        }
    }
}
