using Microsoft.EntityFrameworkCore;
using SlabMaker.Models; // Replace with your models' namespace

namespace SlabMaker.Data // Replace with your namespace
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Set default schema to 'SM'
            modelBuilder.HasDefaultSchema("SM");
        }
    }
}