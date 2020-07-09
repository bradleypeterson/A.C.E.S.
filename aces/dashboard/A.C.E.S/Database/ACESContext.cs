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
        public DbSet<Student> Students{ get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<StudentAssignment> StudentAssignments { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Commit> Commits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<StudentAssignment>().ToTable("StudentAssignment");
            modelBuilder.Entity<Submission>().ToTable("Submission");
            modelBuilder.Entity<Commit>().ToTable("Commit");
        }
    }
}