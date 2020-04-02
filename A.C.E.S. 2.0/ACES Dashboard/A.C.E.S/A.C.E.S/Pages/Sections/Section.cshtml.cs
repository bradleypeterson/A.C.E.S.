using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.C.E.S.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace A.C.E.S.Pages.Sections
{
    public class SectionModel : PageModel
    {
        public Section section { get; set; }
        public List<Student> students { get; set; }
        public void OnGet(int ID)
        {
            section = new Section();
            section.ID = ID;
            section.Name = "CS 2420 Summer 2020";
            section.Archived = false;
            section.Students = new List<Student>();
            section.Students.Add(new Student());
            section.Students.ToList()[0].ID = 1000;
            section.Students.ToList()[0].Name = "John Doe";
            section.Students.ToList()[0].Email = "johndoe@school.edu";
            section.Students.ToList()[0].Standing = Standing.Good;
            section.Students.ToList()[0].Archived = false;

            students = new List<Student>();
            students.Add(new Student());
            students[0].ID = 1000;
            students[0].Name = "John Doe";
            students[0].Email = "johndoe@school.edu";
            students[0].Standing = Standing.Good;
            students[0].Archived = false;
            students.Add(new Student());
            students[1].ID = 1001;
            students[1].Name = "Jane Doe";
            students[1].Email = "janedoe@school.edu";
            students[1].Standing = Standing.Good;
            students[1].Archived = false;
        }
    }
}
