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
        public List<Student> Students { get; set; }

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
            //Sections.Add(new Section());
            //Sections[1].ID = 1000;
            //Sections[1].Name = "CS 2420 Spring 2020";
            //Sections[1].Archived = true;
            //Sections[1].Students.Add(new Student());
            //Sections[1].Students.ToList()[0].ID = 1000;
            //Sections[1].Students.ToList()[0].Name = "John Doe";
            //Sections[1].Students.ToList()[0].Email = "johndoe@school.edu";
            //Sections[1].Students.ToList()[0].Standing = Standing.Good;
            //Sections[1].Students.ToList()[0].Archived = false;
            //Sections.Add(new Section(1000, "CS 2420 Summer 2020", true));
            //Sections.Add(new Section(1000, "CS 4550 Summer 2020", false));
            Students = new List<Student>();
            Students.Add(new Student());
            Students[0].ID = 1000;
            Students[0].Name = "John Doe";
            Students[0].Email = "johndoe@school.edu";
            Students[0].Standing = Standing.Good;
            Students[0].Archived = false;
            Students.Add(new Student());
            Students[1].ID = 1000;
            Students[1].Name = "Jane Doe";
            Students[1].Email = "janedoe@school.edu";
            Students[1].Standing = Standing.Good;
            Students[1].Archived = false;
        }
    }
}
