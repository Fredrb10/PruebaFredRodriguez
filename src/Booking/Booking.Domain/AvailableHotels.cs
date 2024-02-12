
namespace Booking.Domain
{
    public class AvailableHotels
    {
        public int HotelId { get; set; }
        public string Hotel { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int RoomId { get; set; }
        public string Room { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public double BasePrice { get; set; }
    }
}
