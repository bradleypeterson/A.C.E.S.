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
    public class SectionModel : PageModel
    {
        public Section section { get; set; }
        public List<Student> students { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public SectionModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            section = await _context.Sections
                .Include(s => s.Students)
                .Where(s => s.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            students = await _context.Students
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
