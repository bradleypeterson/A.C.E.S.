using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using A.C.E.S.Models;

namespace A.C.E.S.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ACESContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student { Name = "Test Student", Email = "test@test.com", Standing = Standing.Bad, Archived = false }
            };

            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}