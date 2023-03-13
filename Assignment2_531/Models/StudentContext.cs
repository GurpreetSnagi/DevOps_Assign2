using Microsoft.EntityFrameworkCore;

namespace Assignment2_531.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 531,
                    FirstName = "Gurpreet",
                    LastName = "Singh",
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Gagan",
                    LastName = "Joshi",
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Lovepreet",
                    LastName = "Kaur",
                }

            );
        }
    }
}
