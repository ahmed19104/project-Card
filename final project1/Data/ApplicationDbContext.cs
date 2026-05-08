
using final_project1.Models;
using Microsoft.EntityFrameworkCore;
using final_project1.Models;
using final_project1.Models;

namespace final_project1.Data
{

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AHMEDYASSER\\SQLEXPRESS;Database=Final_Project2;TrustServerCertificate=True;Trusted_Connection=True;");
        }   
       
    }
}

