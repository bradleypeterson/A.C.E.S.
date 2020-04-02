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
        public List<Student> Students { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public SectionsModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Sections = await _context.Sections
                .Include(s => s.Students)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
