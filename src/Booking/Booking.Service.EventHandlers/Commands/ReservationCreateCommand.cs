using MediatR;

namespace Booking.Service.EventHandlers.Commands
{
    public class ReservationCreateCommand : INotification
    {
        public int DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactPhone { get; set; }

        public int HotelId { get; set; }
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DepartureDate { get; set; }


    }
}
