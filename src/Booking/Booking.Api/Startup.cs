using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MediatR;
using Booking.Persistence.Database;
using Booking.Service.Queries;
using Microsoft.OpenApi.Models;

namespace Booking.Api
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
                                  x => x.MigrationsHistoryTable("_EFMigrationHistoryBooking")));

            services.AddMediatR(Assembly.Load("Booking.Service.EventHandlers"));

            services.AddTransient<IReservationQueryService, ReservationQueryService>();
            services.AddTransient<IClientQueryService, ClientQueryService>();

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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prueba Fred Rodriguez V1");
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
