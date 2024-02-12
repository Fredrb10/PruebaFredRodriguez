using Admin.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.Persistence.Database.Configuration
{
    public class CityConfiguration
    {
        public CityConfiguration(EntityTypeBuilder<City> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CityId);
            entityBuilder.Property(x => x.Name).IsRequired();

            List<City> cities = new List<City>
            {
                new City { CityId = 1, Name = "Bogota" },
                new City { CityId = 2, Name = "Medellin"},
                new City { CityId = 3, Name = "Cali"},
                new City { CityId = 4, Name = "Cartagena"},
                new City { CityId = 5, Name = "Bucaramanga"}
            };
            entityBuilder.HasData(cities);
        }
        
    }
}
