using Admin.Persistence.Database;
using Admin.Service.Queries.DTOs;
using Common.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Admin.Service.Queries
{
    public interface IRoomQueryService
    {
        Task<List<RoomDto>> GetAllAsync();
    }
    public class RoomQueryService: IRoomQueryService
    {
        private readonly ApplicationDbContext _context;
        public RoomQueryService(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task<List<RoomDto>> GetAllAsync()
        {
            var cities = await _context.Rooms.ToListAsync();

            return cities.MapTo<List<RoomDto>>();
        }
    }
}
