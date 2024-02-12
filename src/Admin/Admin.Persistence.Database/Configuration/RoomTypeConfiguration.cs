
using Admin.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.Persistence.Database.Configuration
{
    public class RoomTypeConfiguration
    {
        public RoomTypeConfiguration(EntityTypeBuilder<RoomType> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.RoomTypeId);
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Capacity).IsRequired();

            List<RoomType> roomTypes = new List<RoomType>
            {
                new RoomType{ RoomTypeId = 1, Name = "Suite Familiar", Capacity = 6 },
                new RoomType{ RoomTypeId = 2, Name = "Habitacion Triple", Capacity = 3 },
                new RoomType{ RoomTypeId = 3, Name = "Habitacion con Terraza", Capacity = 4 },
                new RoomType{ RoomTypeId = 4, Name = "Habitacion Individual", Capacity = 1 },
                new RoomType{ RoomTypeId = 5, Name = "Habitacion Doble", Capacity = 2 }
            };

            entityBuilder.HasData(roomTypes);

        }
    }
}
