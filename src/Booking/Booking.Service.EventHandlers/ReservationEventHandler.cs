using Booking.Domain;
using Booking.Persistence.Database;
using Booking.Service.EventHandlers.Commands;
using Booking.Service.Queries;
using MediatR;

namespace Booking.Service.EventHandlers
{
    public class ReservationEventHandler : INotificationHandler<ReservationCreateCommand>
    {
        private readonly IClientQueryService _clientQueryService;
        private readonly ApplicationDbContext _context;
        public ReservationEventHandler(ApplicationDbContext context, IClientQueryService clientQueryService)
        {
            _clientQueryService = clientQueryService;
            _context = context;
        }
        public async Task Handle(ReservationCreateCommand command, CancellationToken cancellationToken)
        {
            if(! _clientQueryService.ClientExists(command.DocumentNumber))
            {
                await _context.AddAsync(new Customer
                {
                    DocumentType = command.DocumentType,
                    DocumentNumber = command.DocumentNumber,
                    Name = command.Name,
                    LastName = command.LastName,
                    Birthdate = command.Birthdate,
                    Gender = command.Gender,
                    Email = command.Email,
                    Phone = command.Phone,
                    EmergencyContact = command.EmergencyContact,
                    EmergencyContactPhone = command.EmergencyContactPhone
                });
            }
           
            await _context.AddAsync(new Reservation
            {
                HotelId = command.HotelId,
                RoomId = command.RoomId,
                CustomerId = command.CustomerId,
                AdmissionDate = command.AdmissionDate,
                DepartureDate = command.DepartureDate
            });

            await _context.SaveChangesAsync();
        }

      
    }
}
