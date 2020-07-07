using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using A.C.E.S.Models;

namespace A.C.E.S.Data
{
    //Class to insert data on first time run, not neccessary
    public static class DbInitializer
    {
        public static void Initialize(ACESContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            // Create new data to be put into database
            var students = new Student[]
            {
                new Student { Name = "Test Student", Email = "test@test.com", Archived = false } //,
                // new Student { .... },
            };

            //Loop through each object to get to add it to the database
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }

            //foreach (Assignment a in assignments)
            //{
            //  context.Assignments.Add(a);
            //}

            //Anytime changes are made to the database, you have to save them. Don't forget.
            context.SaveChanges();
        }
    }
}