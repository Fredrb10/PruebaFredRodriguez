
using Booking.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Persistence.Database.Configuration
{
    public class ReservationConfiguration
    {
        public ReservationConfiguration(EntityTypeBuilder<Reservation> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ReservationId);
            entityBuilder.Property(x => x.HotelId).IsRequired();
            entityBuilder.Property(x => x.RoomId).IsRequired();
            entityBuilder.Property(x => x.CustomerId).IsRequired();
            entityBuilder.Property(x => x.AdmissionDate).IsRequired();
            entityBuilder.Property(x => x.DepartureDate).IsRequired();

            List<Reservation> reservation = new List<Reservation>
            {
                new Reservation{ ReservationId = 1, HotelId =1, RoomId = 5, CustomerId = 102078256, AdmissionDate = DateTime.Now, DepartureDate = DateTime.Now.AddDays(2)},
                new Reservation{ ReservationId = 2, HotelId = 1, RoomId = 5, CustomerId = 17896582, AdmissionDate = DateTime.Now, DepartureDate = DateTime.Now.AddDays(2)}
            };

            entityBuilder.HasData(reservation);
        }
    }
}
