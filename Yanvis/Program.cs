using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
//using Yanvis.Components;
using Yanvis.Domain;
using Yanvis.Domain.Repositories;

namespace Yanvis;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        //var connectionString = builder.Configuration.GetConnectionString("Default");
        //builder.Services.AddDbContext<YanvisContext>(options =>
        //    options.UseNpgsql(connectionString));

        //Для изменения БД в случае чего
        builder.Services.AddDbContext<YanvisDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        //builder.Services.AddDbContext<YanvisDbContext>(options =>
        //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        //builder.Services.AddDbContext<YanvisDbContext>(options =>
        //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Регистрация репозитория
        builder.Services.AddScoped(typeof(IRepository<>), typeof(PostgresRepository<>));

        //builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => options.LoginPath = "/account");
        builder.Services.AddAuthorization();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
        //// Add services to the container.
        //builder.Services.AddRazorComponents()
        //    .AddInteractiveServerComponents();

        //var app = builder.Build();

        //// Configure the HTTP request pipeline.
        //if (!app.Environment.IsDevelopment())
        //{
        //    app.UseExceptionHandler("/Error");
        //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //    app.UseHsts();
        //}

        //app.UseHttpsRedirection();

        //app.UseStaticFiles();
        //app.UseAntiforgery();

        //app.MapRazorComponents<App>()
        //    .AddInteractiveServerRenderMode();

        //app.Run();
    }
}
