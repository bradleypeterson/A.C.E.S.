using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using A.C.E.S.Models;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Students
{
    public class StudentsModel : PageModel
    {
        public List<Student> students { get; set; }

        [BindProperty]
        public Student Student { get; set; }

        private readonly Data.ACESContext _context;

        public StudentsModel(Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            students = await _context.Students
                .AsNoTracking()
                .ToListAsync();
        }

        public JsonResult OnGetArchive(int id, bool archive)
        {
            var student = _context.Students.Find(id);

            if (student == null)
            {
                return new JsonResult(false);
            }

            if (_context.SaveChanges() == 0)
                return new JsonResult(false);

            return new JsonResult(true);
        }
    }
}
