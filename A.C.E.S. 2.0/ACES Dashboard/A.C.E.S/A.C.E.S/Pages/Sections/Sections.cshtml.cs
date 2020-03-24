using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Sections
{
    public class SectionsModel : PageModel
    {
        public List<Section> Sections { get; set; }

        public void OnGet()
        {
            Sections = new List<Section>();
            Sections.Add(new Section(1000, "CS 1410 Summer 2020", false));
            Sections.Add(new Section(1000, "CS 2420 Summer 2020", true));
            Sections.Add(new Section(1000, "CS 4550 Summer 2020", false));
        }
    }
}
