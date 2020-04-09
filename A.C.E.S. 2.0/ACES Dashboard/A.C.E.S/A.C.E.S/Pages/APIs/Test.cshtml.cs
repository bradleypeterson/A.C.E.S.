using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.APIs
{
    public class TestModel : PageModel
    {
        public Section Section { get; set; }
        private readonly A.C.E.S.Data.ACESContext _context;

        public TestModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public JsonResult OnGetSection(int id)
        {
            var section = _context.Sections.FirstOrDefault(s => s.ID == id);
            section.Course = _context.Courses.FirstOrDefault(c => c.ID == section.CourseID);

            return new JsonResult(section);
        }
    }
}
