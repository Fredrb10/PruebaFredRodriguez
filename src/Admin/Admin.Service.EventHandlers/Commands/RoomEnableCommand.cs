
using MediatR;

namespace Admin.Service.EventHandlers.Commands
{
    public class RoomEnableCommand:INotification
    {
        public int RoomId { get; set; }
        public int Enabled { get; set; }
    }
}
