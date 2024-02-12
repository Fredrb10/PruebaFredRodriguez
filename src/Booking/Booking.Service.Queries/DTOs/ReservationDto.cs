
namespace Booking.Service.Queries.DTOs
{
    public class ReservationDto
    {
        public int ReservationId { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
