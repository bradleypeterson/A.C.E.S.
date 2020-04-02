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
    public class EditModel : PageModel
    {
        public Student student { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public EditModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            student = await _context.Students
                .Where(s => s.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Student();

            if (await TryUpdateModelAsync<Student>(
                emptyStudent,
                "student",   // Prefix for form value.
                s => s.Name, s => s.Email, s => s.Standing, s => s.Archived))
            {
                //_context.Students.Where(s => s.ID == student.ID).FirstOrDefault() = student;
                _context.Students.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Students");
            }

            return Page();
        }
    }
}
