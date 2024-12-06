using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Yanvis.Domain
{
    public class YanvisContextFactory : IDesignTimeDbContextFactory<YanvisContext>
    {
        public YanvisContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<YanvisContext>();

            // Укажите строку подключения (замените на вашу строку)
            optionsBuilder.UseNpgsql("Host=localhost;Database=YourDatabase;Username=YourUsername;Password=YourPassword");

            return new YanvisContext(optionsBuilder.Options);
        }
    }
}
