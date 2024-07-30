using Microsoft.EntityFrameworkCore;
using MVC_Lab1.Models;

namespace MVC_Lab1.Context
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = KAREEM\\SQLEXPRESS; Database = MVC1; Trusted_Connection = true; Encrypt = false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }  
    }
}
