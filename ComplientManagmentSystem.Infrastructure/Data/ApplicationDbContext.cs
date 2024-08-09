using Microsoft.EntityFrameworkCore;
using ComplaintManagementSystem.Domain.Entities;

namespace ComplientManagmentSystem.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<User> Users { get; set; }


        // Override OnModelCreating if you need to configure model relationships, etc.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Model configurations go here
        }
    }
}
