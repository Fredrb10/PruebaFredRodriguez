
using Admin.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.Persistence.Database.Configuration
{
    public class HotelTypeConfiguration
    {
        public HotelTypeConfiguration(EntityTypeBuilder<HotelType> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.HotelTypeId);
            entityBuilder.Property(x => x.Star).IsRequired();

            List<HotelType> hotelTypes = new List<HotelType>();

             for (int i = 1; i <= 5; i++)
            {
                hotelTypes.Add(new HotelType
                {
                    HotelTypeId = i,
                    Star = i
                });
            }
            entityBuilder.HasData(hotelTypes);

        }
    }
}
