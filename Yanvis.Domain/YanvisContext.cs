using Microsoft.EntityFrameworkCore;
using Yanvis.Domain.Tables;

namespace Yanvis.Domain;

public class YanvisContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Scheme> Schemes { get; set; }
    public DbSet<JsonRecord> JsonRecords { get; set; }
    public YanvisContext(DbContextOptions<YanvisContext> options) : base(options)
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