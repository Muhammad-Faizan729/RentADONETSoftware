using Microsoft.EntityFrameworkCore;
using RentADOSoftware.Core.Entities;

public class RentADOSoftwareDbContext : DbContext
{
    public RentADOSoftwareDbContext(DbContextOptions<RentADOSoftwareDbContext> options)
        : base(options)
    {
    }

    public DbSet<Agent> Agents { get; set; }
    public DbSet<Rent> Rents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=RentADONETSoftware; Trusted_Connection=true; TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
