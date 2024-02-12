using Admin.Domain;
using Admin.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Admin.Persistence.Database
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options ) : base( options ) 
        {
        
        }

        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }

        public DbSet<City>Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelType> HotelTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new CityConfiguration(modelBuilder.Entity<City>());
            new HotelConfiguration(modelBuilder.Entity<Hotel>());
            new HotelTypeConfiguration(modelBuilder.Entity<HotelType>());
            new RoomConfiguration(modelBuilder.Entity<Room>());
            new RoomTypeConfiguration(modelBuilder.Entity<RoomType>());
        }


    }
}
