using Admin.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.Persistence.Database.Configuration
{
    public class HotelConfiguration
    {
        public HotelConfiguration(EntityTypeBuilder<Hotel> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.HotelId);
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Address).IsRequired();
            entityBuilder.Property(x => x.Phone).IsRequired();

            List<Hotel> hotels = new List<Hotel>();

            for(int i = 1; i <= 5; i++)
            {
                hotels.Add(new Hotel
                {
                     HotelId = i,
                     HotelTypeId = i,
                     CityId = i,
                     Name = $"Hotel {i}",
                     Address =$"Direccion Hotel {i}",
                     Phone = $"267001{i}",
                     Enabled = 1
                      
                });
            }
            entityBuilder.HasData(hotels);
        }

    }
}
