namespace Booking.Domain
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DepartureDate { get; set; }

    }
}
