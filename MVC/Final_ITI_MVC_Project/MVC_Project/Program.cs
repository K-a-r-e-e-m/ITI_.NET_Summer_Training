using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Areas.Identity.Data;
namespace MVC_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("MVC_ProjectContextConnection") ?? throw new InvalidOperationException("Connection string 'MVC_ProjectContextConnection' not found.");

            builder.Services.AddDbContext<MVC_ProjectContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<MVC_ProjectUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<MVC_ProjectContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=LandingPage}/{action=Index}/{id?}");
            
            app.MapRazorPages();
            app.Run();
        }
    }
}
