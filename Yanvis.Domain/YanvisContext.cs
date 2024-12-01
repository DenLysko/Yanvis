using Microsoft.EntityFrameworkCore;

namespace Yanvis.Domain;

public class YanvisContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Scheme> Schemes { get; set; }
    public YanvisContext(DbContextOptions<YanvisContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=mydb;Username=myuser;Password=mypassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}


//public class UserContext : DbContext
//{
//    public DbSet<User> Users { get; set; }
//    public string Schemes { get; set; }
//    public UserContext(DbContextOptions<YanvisContext> options) : base(options)
//    {
//    }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseNpgsql("Host=localhost;Database=mydb;Username=myuser;Password=mypassword");
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {

//    }
//}
