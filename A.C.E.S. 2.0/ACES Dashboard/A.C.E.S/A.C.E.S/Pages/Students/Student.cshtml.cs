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
    public class StudentModel : PageModel
    {
        public int ID { get; set; }
        public Student student { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public StudentModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            ID = id;
            student = await _context.Students
                .Where(s => s.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            student.Submissions = await _context.Submissions
                .Where(s => s.StudentID == id)
                .OrderBy(s => s.DateTime)
                .AsNoTracking()
                .ToArrayAsync();
        }
    }
}
