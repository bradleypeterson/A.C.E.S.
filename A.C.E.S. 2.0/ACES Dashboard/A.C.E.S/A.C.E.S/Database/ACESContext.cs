using A.C.E.S.Models;
using Microsoft.EntityFrameworkCore;

namespace A.C.E.S.Data
{
    public class ACESContext : DbContext
    {
        public ACESContext(DbContextOptions<ACESContext> options) : base(options)
        {
        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Submission>().ToTable("Submission");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<StudentAssignment>().ToTable("StudentAssignment");
            modelBuilder.Entity<Section>().ToTable("Section");
        }
    }
}