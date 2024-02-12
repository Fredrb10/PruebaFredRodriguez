using Booking.Domain;
using Booking.Persistence.Database;
using Booking.Service.Queries.DTOs;
using Common.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Booking.Service.Queries
{
    public interface ICheckHotelsQueryService
    {
        Task<List<AvailableHotelsDto>> GetAvailableHotel(CheckHotels consult);
        Task<List<ReservationDto>> GetReservationsHotel(int id);
    }
    public class CheckHotelsQueryService:ICheckHotelsQueryService
    {
        private readonly ApplicationDbContext _context;
        public CheckHotelsQueryService(ApplicationDbContext context)
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




    } 
}
