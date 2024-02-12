
using MediatR;

namespace Admin.Service.EventHandlers.Commands
{
    public class RoomCreateCommand:INotification
    {
        public int IdHotel { get; set; }
        public int IdRoomType { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public double BasePrice { get; set; }
        public double Tax { get; set; }
        public int Enabled { get; set; }
    }
}
