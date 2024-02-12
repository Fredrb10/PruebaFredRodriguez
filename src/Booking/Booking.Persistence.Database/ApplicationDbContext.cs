
using Booking.Domain;
using Booking.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Booking.Persistence.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<IdentificationType> IdentificationTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<AvailableHotels>(e => e.HasNoKey());

            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new CustomerConfiguration(modelBuilder.Entity<Customer>());
            new IdentificationTypeConfiguration(modelBuilder.Entity<IdentificationType>());
            new ReservationConfiguration(modelBuilder.Entity<Reservation>());
        }

    }
}
