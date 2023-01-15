using Microsoft.EntityFrameworkCore;

namespace CvApp.Models
{
    public class CvAppContext : DbContext
    {
        public CvAppContext(DbContextOptions<CvAppContext> options) : base(options)
        {
        }

        public DbSet<CvModel> CvModels { get; set; }
        public DbSet<Degree> DegreeEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>().ToTable("Course");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            //modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
