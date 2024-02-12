using Booking.Domain;
using Booking.Persistence.Database;
using Booking.Service.Queries.DTOs;
using Common.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Queries
{
    public interface IReservationQueryService
    {
        Task<List<AvailableHotelsDto>> GetAvailableHotel(CheckHotels consult);
        Task<List<ReservationDto>> GetReservationsHotel(int id);
        IEnumerable<ReservationDetail> Reservation(int reserva);
    }
    public class ReservationQueryService:IReservationQueryService
    {
        private readonly ApplicationDbContext _context;
        public ReservationQueryService(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<List<AvailableHotelsDto>> GetAvailableHotel(CheckHotels consult)
        {
            var consultHotel =  _context.Set<AvailableHotels>().FromSqlInterpolated($@"EXEC dbo.SpConsultHotel @CityId = {consult.CityId}, 
                                                                                                              @Capacity = {consult.Capacity}, 
                                                                                                              @AdmissionDate = {consult.AdmissionDate}, 
                                                                                                              @DepartureDate = {Convert.ToDateTime(consult.DepartureDate).AddDays(1):yyyy-MM-dd}").ToList();
                
            return consultHotel.MapTo<List<AvailableHotelsDto>>();
        }

        public async Task<List<ReservationDto>> GetReservationsHotel(int id)
        {
            return  _context.Reservations.Where(x => x.HotelId == id).ToList().MapTo<List<ReservationDto>>(); 
        }

        public IEnumerable<ReservationDetail> Reservation(int reservationId)
        {
            var reservationDetails = from reservation in _context.Reservations
                                     join customer in _context.Customers
                                       on reservation.CustomerId equals customer.DocumentNumber
                                     join idenType in _context.IdentificationTypes
                                       on customer.DocumentType equals idenType.TypeId
                                    where reservation.ReservationId == reservationId
                                     select new ReservationDetail
                                     {
                                         ReservationId = reservation.ReservationId,
                                         HotelId = reservation.HotelId,
                                         RoomId = reservation.RoomId,
                                         TypeIdentification = idenType.Type,
                                          CustomerId = reservation.CustomerId,
                                           Name = customer.Name,
                                           LastName = customer.LastName,
                                           Phone = customer.Phone,
                                           Email = customer.Email,
                                         AdmissionDate = reservation.AdmissionDate,
                                         DepartureDate = reservation.DepartureDate
                                     };
           return reservationDetails.ToList().AsEnumerable();

        }






    } 
}
