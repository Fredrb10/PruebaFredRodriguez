using MediatR;

namespace Admin.Service.EventHandlers.Commands
{
    public class HotelEnableCommand : INotification
    {
        public int HotelId { get; set; }
        public int Enabled { get; set; }
    }
}
