
using Admin.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.Persistence.Database.Configuration
{
    public class RoomConfiguration
    {
        public RoomConfiguration(EntityTypeBuilder<Room> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.RoomId);
            entityBuilder.Property(x => x.RoomNumber).IsRequired();

            List<Room> rooms = new List<Room>
            {
                new Room { RoomId = 1, IdHotel = 1, IdRoomType = 1, RoomNumber = 101, Floor = 1, BasePrice = 40000, Tax = 7600,  Enabled = 1 },
                new Room { RoomId = 2, IdHotel = 2, IdRoomType = 2, RoomNumber = 204, Floor = 2, BasePrice = 60000, Tax = 11400, Enabled = 1 },
                new Room { RoomId = 3, IdHotel = 3, IdRoomType = 3, RoomNumber = 308, Floor = 3, BasePrice = 75000, Tax = 14250, Enabled = 1 },
                new Room { RoomId = 4, IdHotel = 4, IdRoomType = 4, RoomNumber = 406, Floor = 4, BasePrice = 110000, Tax = 20900,Enabled = 1},
                new Room { RoomId = 5, IdHotel = 5, IdRoomType = 5, RoomNumber = 502, Floor = 5, BasePrice = 160000, Tax = 30400,Enabled = 1}
            };
            entityBuilder.HasData(rooms);

        }
    }
}
