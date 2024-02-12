using Booking.Persistence.Database;

namespace Booking.Service.Queries
{
    public interface IClientQueryService
    {
        bool ClientExists(int clientId);
    }
    public class ClientQueryService: IClientQueryService
    {
        private readonly ApplicationDbContext _context;
        public ClientQueryService(ApplicationDbContext context)
        {
            _context = context;

        }
        public bool ClientExists(int clientId)
        {
            var client = _context.Customers.FirstOrDefault(x => x.DocumentNumber == clientId);

            if (client == null) return false;

            return true;
        }


    }
}
