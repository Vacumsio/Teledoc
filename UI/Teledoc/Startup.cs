using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Teledoc.DAL.Context;
using Teledoc.Interfaces.Services;
using Teledoc.Services.Data;
using Teledoc.Services.DataStore.InSQL;

namespace Teledoc
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TeledocDB>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<TeledocDBInitializator>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddScoped<IClientsData, SqlClientsData>();
            services.AddScoped<IFoundersData, SqlFoundersData>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TeledocDBInitializator db)
        {
            db.Initialize();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
