
using Microsoft.EntityFrameworkCore;
using Admin.Persistence.Database;
using Admin.Service.Queries;
using System.Reflection;
using MediatR;

namespace Admin.Api
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
            services.AddDbContext<ApplicationDbContext>(
               options => options.UseSqlServer(
                                  Configuration.GetConnectionString("Conn"),
                                  x => x.MigrationsHistoryTable("_EFMigrationHistoryAdmin")));

            services.AddMediatR(Assembly.Load("Admin.Service.EventHandlers"));

            services.AddTransient<IHotelQueryService, HotelQueryService>();
            services.AddTransient<IRoomQueryService, RoomQueryService>();
            services.AddControllers();





        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
