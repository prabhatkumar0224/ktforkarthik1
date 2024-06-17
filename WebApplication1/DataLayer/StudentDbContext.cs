using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataLayer
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options) { }
        public DbSet<Student> students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(s=>new
                { 
                    s.rollno
                });
        }
    }
}
