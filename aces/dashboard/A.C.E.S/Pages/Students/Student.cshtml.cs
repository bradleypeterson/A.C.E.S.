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
        public List<SectionStudent> SectionStudents { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Submission> Submissions { get; set; }
        public List<Assignment> RecentSubmissions { get; set; }

        private readonly A.C.E.S.Data.ACESContext _context;

        public StudentModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id)
        {
            Student = await _context.Students
                .Where(s => s.ID == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            Submissions = await _context.Submissions
                .Where(s => s.StudentID == id)
                .OrderBy(s => s.DateTime)
                .AsNoTracking()
                .ToListAsync();

            // Get the first 5 recent submissions and get those submission's assignment info
            RecentSubmissions = new List<Assignment>();
            int count = 0;
            foreach (var submission in Submissions)
            {
                submission.Assignment = await _context.Assignments
                    .FindAsync(submission.AssignmentID);

                // If multiple submissions were made for the same assignment, ignore them
                if (!RecentSubmissions.Exists(s => s.ID == submission.Assignment.ID))
                {
                    RecentSubmissions.Add(submission.Assignment);
                    count++;
                }
                if (count == 5) break;
            }
            SectionStudents = await _context.SectionStudents
                .Where(s => s.StudentID == id)
                .AsNoTracking()
                .ToListAsync();
            Assignments = await _context.Assignments.ToListAsync();
        }
    }
}
