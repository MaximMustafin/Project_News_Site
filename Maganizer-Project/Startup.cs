using Maganizer_Project.DAL.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Maganizer_Project.DAL.Interfaces;
using Maganizer_Project.DAL.Repositories;
using Maganizer_Project.BLL.Interfaces;
using Maganizer_Project.BLL.Services;
using Maganizer_Project.DAL.Entities;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;

namespace Maganizer_Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddDbContext<MaganizerContext>(options =>
            {
                var connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);

            });

            services.AddIdentity<ApplicationUser, IdentityRole>(config => { config.SignIn.RequireConfirmedEmail = true; })
                .AddEntityFrameworkStores<MaganizerContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = Configuration["Application:LoginPath"];
            });

            var mailKitOptions = Configuration.GetSection("Email").Get<MailKitOptions>();
            services.AddMailKit(config => 
            {
                config.UseMailKit(mailKitOptions);
            });

            services.AddScoped<IUnitOfWork, EFUnitOfWork>();

            services.AddScoped<IAccountService, UserAccountService>();
            services.AddScoped<IUserProfileService, UserProfileService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {           
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/missing";
                    await next();
                }
            });
            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id}");
            });
        }
    }
}
