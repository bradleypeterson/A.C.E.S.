using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Courses.Assignments
{
    public class AssignmentModel : PageModel
    {
        public int CourseID;
        public Assignment Assignment { get; set; }
        public void OnGet(int courseID, int ID)
        {
            CourseID = courseID;
            Assignment = new Assignment(ID, "Assignment");
        }
    }
}
