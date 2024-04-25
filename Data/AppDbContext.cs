using Microsoft.EntityFrameworkCore;
using RexixBackend.DTOs;

namespace RexixBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BrandDTO> Brand { get; set; }
        public DbSet<PersonDTO> Person { get; set; }
        public DbSet<ProductDTO> Product { get; set; }
        public DbSet<ReplyDTO> Reply { get; set; }
        public DbSet<ReviewDTO> Review { get; set; }

        // Define your DbSet properties here for each entity in your database

        // Example:
        // public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity configurations here

            // Example:
            // modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}