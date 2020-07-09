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
        public Student Student { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Submission> Submissions { get; set; }
        public List<Submission> RecentSubmissions { get; set; }

        private readonly Data.ACESContext _context;

        public StudentModel(Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int studentId)
        {
            // Initialize stuff:
            Assignments = new List<Assignment>();
            Submissions = new List<Submission>();

            // Get Student:
            Student = await _context.Students
                .Where(s => s.Id == studentId)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            // Get StudentAssignments:
            var studentAssignments = await _context.StudentAssignments
                .Where(s => s.StudentId == studentId).ToListAsync();

            // Get all Assignments related to student:
            foreach (var itm in studentAssignments)
            {
                Assignments.Add(itm.Assignment);
            }

            // Gets the all submissions:
            foreach (var itm in studentAssignments)
            {
                foreach (var submission in itm.Submissions)
                {
                    Submissions.Add(submission);
                }
            }

            // Get the most recent 5 sumissions:
            RecentSubmissions = Submissions.OrderBy(s => s.DateSubmitted).Take(5).ToList();
        }
    }
}
