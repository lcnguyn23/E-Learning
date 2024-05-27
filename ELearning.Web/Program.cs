using ELearning.Business.Services.Implementation;
using ELearning.Business.Services.Implementations;
using ELearning.Business.Services.Interfaces;
using ELearning.Business.Utility;
using ELearning.Data;
using ELearning.Data.Repositories;
using ELearning.Data.Repositories.Implementations;
using ELearning.Data.Repositories.Interfaces;
using ELearning.DomainModels.User;
using ELearning.Web.AppCodes;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();

            builder.Services.AddHttpContextAccessor();
            // Configure Entity Framework Core
            builder.Services.AddDbContext<ELearningDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddRazorPages();
            builder.Services.AddMvc();

            builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>()
                            .AddEntityFrameworkStores<ELearningDbContext>()
                            .AddDefaultTokenProviders();
            
            builder.Services.AddAuthentication()
            .AddCookie("AdminLogin", options =>
            {
                options.LoginPath = "/Account/AdminLogin"; 
                options.LogoutPath = "/Account/Logout"; 
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
            })
            .AddCookie("StudentInstructorLogin", options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout"; 
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
            });
            

            builder.Services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(20);
                option.Cookie.HttpOnly = true;
                option.Cookie.IsEssential = true;
            });



            builder.Services.AddScoped<UserManager<ApplicationUser>>();
            builder.Services.AddScoped<SignInManager<ApplicationUser>>();

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddScoped<ICourseRepository, CourseRepository>();
            builder.Services.AddScoped<ICourseRatingRepository, CourseRatingRepository>();
            builder.Services.AddScoped<ICourseRequestRepository, CourseRequestRepository>();
            builder.Services.AddScoped<ISectionRepository, SectionRepository>();
            builder.Services.AddScoped<ILessonContentRepository, LessonContentRepository>();
            builder.Services.AddScoped<ILessonRepository, LessonRepository>(); 
            builder.Services.AddScoped<ITopicRepository, TopicRepository>();
            builder.Services.AddScoped<ILevelRepository, LevelRepository>();
            builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();

            builder.Services.AddScoped<ILessonService, LessonService>();
            builder.Services.AddScoped<ILevelService, LevelService>();
            builder.Services.AddScoped<ITopicService, TopicService>();
            builder.Services.AddScoped<ISectionService, SectionService>();
            builder.Services.AddScoped<ICourseService, CourseService>();
            builder.Services.AddScoped<ICourseRequestService, CourseRequestService>();

            builder.Services.AddTransient<SelectListHelper>();


            builder.Services.AddControllersWithViews()
                .AddMvcOptions(option =>
                {
                    option.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true; //Không sử dụng thông báo mặc định cho giá trị null
                }); 
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

            app.UseSession();

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
                    pattern: "instructor/{controller=Home}/{action=CreateCourse}/{id?}"
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

            ApplicationContext.Configure
            (
                httpContextAccessor: app.Services.GetRequiredService<IHttpContextAccessor>(),
                hostEnvironment: app.Services.GetService<IWebHostEnvironment>()
            );

            app.Run();
        }
    }
}