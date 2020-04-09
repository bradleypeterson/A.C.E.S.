using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.APIs
{
    public class SectionsModel : PageModel
    {
        private readonly A.C.E.S.Data.ACESContext _context;

        public SectionsModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public JsonResult OnGetGet()
        {
            var sections = _context.Sections.ToList();
            foreach (var section in sections)
            {
                section.Course = _context.Courses.FirstOrDefault(c => c.ID == section.CourseID);
            }

            return new JsonResult(sections);
        }
    }
}
