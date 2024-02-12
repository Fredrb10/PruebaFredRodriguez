using Admin.Persistence.Database;
using Admin.Service.EventHandlers.Commands;
using MediatR;
namespace Admin.Service.EventHandlers
{
    public class RoomEventHandler : INotificationHandler<RoomUpdateCommand>, INotificationHandler<RoomEnableCommand>
    {
        private readonly ApplicationDbContext _context;

        public RoomEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Handle(RoomUpdateCommand command, CancellationToken cancellationToken)
        {
            var room = _context.Rooms.First(a => a.RoomId == command.RoomId);
            room.IdHotel = command.IdHotel;
            room.IdRoomType = command.IdRoomType;
            room.RoomNumber = command.RoomNumber;
            room.Floor = command.Floor;
            room.BasePrice = command.BasePrice;
            room.Tax = command.Tax;
            await _context.SaveChangesAsync();

        }

        public async Task Handle(RoomEnableCommand command, CancellationToken cancellationToken)
        {
            var rooms = _context.Rooms.First(a => a.RoomId == command.RoomId);
            rooms.Enabled = command.Enabled;
            await _context.SaveChangesAsync();

        }

    }
}
