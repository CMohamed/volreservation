using Microsoft.EntityFrameworkCore;
using volreservation.API.Domain.Models;

namespace volreservation.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vol> Vols { get; set; }
        public DbSet<Company> Companies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Company>().ToTable("Companies");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Company>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().HasMany(p => p.Vols).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);

            builder.Entity<Company>().HasData
            (
                new Company { Id = 100, Name = "Qatar Airways" }, // Id set manually due to in-memory provider
                new Company { Id = 101, Name = "Air Arabia" }
            );

            builder.Entity<Vol>().ToTable("Vols");
            builder.Entity<Vol>().HasKey(p => p.Id);
            builder.Entity<Vol>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            // builder.Entity<Vol>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            // builder.Entity<Vol>().Property(p => p.QuantityInPackage).IsRequired();
            // builder.Entity<Vol>().Property(p => p.UnitOfMeasurement).IsRequired();

            builder.Entity<Vol>().HasData
            (
                new Vol { Id = 100 }, // Id set manually due to in-memory provider
                new Vol { Id = 101 }
            );
        }
    }
}