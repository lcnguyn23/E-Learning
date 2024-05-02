using ELearning.Data;
using ELearning.DomainModels.UserRole;
using ELearning.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ELearning.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

                        builder.Services.AddDbContext<ELearningDbContext>(options =>
                options.UseSqlServer(connectionString));

                  
            // Configure Entity Framework Core
            builder.Services.AddDbContext<ELearningDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddRazorPages();
            builder.Services.AddMvc();

            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
                            .AddEntityFrameworkStores<ELearningDbContext>()
                            .AddDefaultTokenProviders();

            builder.Services.AddScoped<UserManager<ApplicationUser>>();
            builder.Services.AddScoped<SignInManager<ApplicationUser>>();

            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "areaAdmin",
                    areaName: "Admin",
                    pattern: "admin/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                    name: "areaInstructor",
                    areaName: "Instructor",
                    pattern: "instructor/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                    name: "areaStudent",
                    areaName: "Student",
                    pattern: "student/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}