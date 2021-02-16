using System;
using AthleticismWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AthleticismWebAPI
{
    public class PGDBContext : DbContext
    {
        public PGDBContext(DbContextOptions<PGDBContext> options) : base(options)
        {
        }
        public DbSet<Review> reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
