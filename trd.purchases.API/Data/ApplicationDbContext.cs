using Microsoft.EntityFrameworkCore;
using trd.purchases.API.Models;

namespace trd.purchases.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Employee entity
            modelBuilder.Entity<Employee>(entity =>
            {
                // Map PersonalNumber property to the database column
                entity.Property(e => e.PersonalNumber)
                      .HasMaxLength(50); // Set the maximum length for the PersonalNumber property
            });
        }
    }
}
