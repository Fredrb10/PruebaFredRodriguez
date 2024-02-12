
using Admin.Domain;
using Admin.Persistence.Database;
using Admin.Service.EventHandlers.Commands;
using MediatR;

namespace Admin.Service.EventHandlers
{
    public class HotelEventHandler : INotificationHandler<HotelCreateCommand>, INotificationHandler<HotelUpdateCommand>, INotificationHandler<HotelEnableCommand>
    {
        private readonly ApplicationDbContext _context;

        public HotelEventHandler(ApplicationDbContext context)
        {
           _context = context;
        }

        public async Task Handle(HotelCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Hotel
            {
                 HotelTypeId = command.HotelTypeId,
                 CityId = command.CityId,
                 Name = command.Name,
                 Address = command.Address,
                 Phone = command.Phone,
                 Enabled = command.Enabled
            });
            await _context.SaveChangesAsync();
        }

        public async Task Handle(HotelUpdateCommand command, CancellationToken cancellationToken)
        {
            var hotel = _context.Hotels.First(a => a.HotelId == command.HotelId);
            hotel.HotelTypeId = command.HotelTypeId;
            hotel.CityId = command.CityId;
            hotel.Name = command.Name;
            hotel.Address = command.Address;
            hotel.Phone = command.Phone;
            await _context.SaveChangesAsync();

        }

        public async Task Handle(HotelEnableCommand command, CancellationToken cancellationToken)
        {
            var hotel = _context.Hotels.First(a => a.HotelId == command.HotelId);
            hotel.Enabled = command.Enabled;
            await _context.SaveChangesAsync();

        }
    }
}
