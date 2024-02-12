namespace Booking.Domain
{
    public class Customer
    {
        public int Id { get; set; }
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


    }
}
