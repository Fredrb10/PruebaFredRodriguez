using Microsoft.OpenApi.Models;
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
            AddSwagger(services);
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Prueba Tecnica {groupName}",
                    Version = groupName,
                    Description = "Fred Rodriguez",
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prueba Tecnica V1");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
