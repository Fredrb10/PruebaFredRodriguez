using Admin.Persistence.Database;
using Admin.Service.Queries.DTOs;
using Common.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Admin.Service.Queries
{
    public interface IHotelQueryService
    {
        Task<List<HotelDto>> GetAllHotels();
    }
    public class HotelQueryService: IHotelQueryService
    {
        private readonly ApplicationDbContext _context;
        public HotelQueryService(ApplicationDbContext context) 
        {
            _context = context;
        
        }

        public async Task<List<HotelDto>> GetAllHotels()
        {
            var cities = await _context.Hotels.ToListAsync();

            return cities.MapTo<List<HotelDto>>();
        }

    }
}
