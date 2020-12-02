

using System;
using Microsoft.EntityFrameworkCore;

namespace TPElectronDemo.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>(x => x.HasData(
                new Country { Id = Guid.NewGuid(), Name = "Croatia" },
                new Country { Id = Guid.NewGuid(), Name = "France" },
                new Country { Id = Guid.NewGuid(), Name = "Great Britain" },
                new Country { Id = Guid.NewGuid(), Name = "Spain" },
                new Country { Id = Guid.NewGuid(), Name = "Italy" }
                ));
            base.OnModelCreating(builder);
        }
    }
}