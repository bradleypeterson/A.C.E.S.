using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Data;
using A.C.E.S.Models;
using A.C.E.S.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Login
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public List<Instructor> Instructors { get; set; }
        public List<Student> Students { get; set; }

        private readonly ACESContext _context;

        public LoginModel(ACESContext context)
        {
            _context = context;
        }

        public async Task OnPostAsync()
        {
            Instructors = await _context.Instructors
                .AsNoTracking()
                .ToListAsync();

            Students = await _context.Students
                .AsNoTracking()
                .ToListAsync();

            AttemptLogin();
        }

        public IActionResult AttemptLogin()
        {
            if (UserName == null || Password == null) return Page();

            var Instructor = Instructors.Where(x => x.Email == UserName).FirstOrDefault();

            // Only check student if it wasn't found in the instructor
            Student Student = null;
            if (Instructor == null)
                Student = Students.Where(x => x.Email == UserName).FirstOrDefault();

            if (Instructor != null)
            {
                var hashedPass = Hashing.ComputeSha256Hash(Password);
                if (hashedPass == Instructor.Password)
                {
                    // figure out cookies and all that jazz...
                    return RedirectToPage("../Courses/Courses");
                }
            } else if (Student != null)
            {
                var hashedPass = Hashing.ComputeSha256Hash(Password);
                if (hashedPass == Student.Password)
                {
                    // figure out cookies and all that jazz...
                    return RedirectToPage("../Courses/Courses");
                }
            } 

            return Page(); // Error
        }
    }
}