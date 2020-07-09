using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Pages.Submissions
{
    public class SubmissionsModel : PageModel
    {
        public Student Student { get; set; }
        public Assignment Assignment { get; set; }
        public List<Submission> Submissions { get; set; }
        private readonly A.C.E.S.Data.ACESContext _context;

        public SubmissionsModel(A.C.E.S.Data.ACESContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int studentID, int assignmentID)
        {
            Student = await _context.Students.FindAsync(studentID);
            Assignment = await _context.Assignments.FindAsync(assignmentID);

            // Get all the submission made by the student for this assignment
            Submissions = await _context.Submissions
                .Where(s => s.AssignmentID == assignmentID)
                .OrderBy(s => s.DateTime)
                .ToListAsync();
        }
    }
}
