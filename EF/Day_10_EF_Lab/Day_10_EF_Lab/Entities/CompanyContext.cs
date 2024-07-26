using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_10_EF_Lab.Models;

namespace Day_10_EF_Lab.Entities
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Create database and connect to it (Connection string Valid only with core)
            optionsBuilder.UseSqlServer("Server = KAREEM\\SQLEXPRESS; Database = LabEF; Trusted_Connection = true; Encrypt = false");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent api Configuration
            modelBuilder.Entity<Instructor_Course>()
                .HasKey(ic => new { ic.InstructorId, ic.CourseId });

            modelBuilder.Entity<Student_Course>()
                .HasKey(ic => new { ic.StudentId, ic.CourseId });

        }
  
        //Build containers for classes that will be entity (table) in DB
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor_Course> Instructor_Courses { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }

    }
}