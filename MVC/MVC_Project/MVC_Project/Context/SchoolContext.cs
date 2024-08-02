using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

namespace MVC_Project.Context
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = KAREEM\\SQLEXPRESS; Database = MVC_Project_ITI; Trusted_Connection = true; Encrypt = false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CrsResult> CrsResults { get; set; }
    }
}
