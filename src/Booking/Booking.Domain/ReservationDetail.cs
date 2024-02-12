
namespace Booking.Domain
{
    public class ReservationDetail
    {
        public int ReservationId { get; set; }
        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public string TypeIdentification { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DepartureDate { get; set; }


    }
}
