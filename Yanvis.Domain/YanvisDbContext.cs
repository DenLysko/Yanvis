using Microsoft.EntityFrameworkCore;

namespace Yanvis.Domain;

public class YanvisDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Scheme> Schemes { get; set; }
    public YanvisDbContext(DbContextOptions<YanvisDbContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=Yanvis;Username=Yanvis;Password=Yanvis1");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}