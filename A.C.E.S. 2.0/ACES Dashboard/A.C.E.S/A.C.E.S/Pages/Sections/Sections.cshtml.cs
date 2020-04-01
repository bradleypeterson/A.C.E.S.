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
            Sections.Add(new Section());
            Sections[0].ID = 1000;
            Sections[0].Name = "CS 2420 Summer 2020";
            Sections[0].Archived = false;
            Sections[0].Students = new List<Student>();
            Sections[0].Students.Add(new Student());
            Sections[0].Students.ToList()[0].ID = 1000;
            Sections[0].Students.ToList()[0].Name = "John Doe";
            Sections[0].Students.ToList()[0].Email = "johndoe@school.edu";
            Sections[0].Students.ToList()[0].Standing = Standing.Good;
            Sections[0].Students.ToList()[0].Archived = false;
            Sections.Add(new Section());
            Sections[1].ID = 1000;
            Sections[1].Name = "CS 2420 Spring 2020";
            Sections[1].Archived = true;
            //Sections.Add(new Section(1000, "CS 2420 Summer 2020", true));
            //Sections.Add(new Section(1000, "CS 4550 Summer 2020", false));
        }
    }
}
