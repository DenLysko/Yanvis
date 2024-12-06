using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Yanvis.Domain
{
    public class YanvisContextFactory : IDesignTimeDbContextFactory<YanvisDbContext>
    {
        public YanvisDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<YanvisDbContext>();

            // Укажите строку подключения (замените на вашу строку)
            optionsBuilder.UseNpgsql("Host=localhost;Database=YourDatabase;Username=YourUsername;Password=YourPassword");

            return new YanvisDbContext(optionsBuilder.Options);
        }
    }
}
