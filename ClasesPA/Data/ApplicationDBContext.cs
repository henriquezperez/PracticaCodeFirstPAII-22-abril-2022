using ClasesPA.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasesPA.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
          : base(options)
        {

        }

       
        public DbSet<Students> Students { get; set; }
        public DbSet<Enrrollements> Enrrollements { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
