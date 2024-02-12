
using Booking.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Persistence.Database.Configuration
{
    public class IdentificationTypeConfiguration
    {
        public IdentificationTypeConfiguration(EntityTypeBuilder<IdentificationType> entityBuilder)
        {
            entityBuilder.HasKey(x => x.TypeId);
            entityBuilder.Property(x => x.Type).IsRequired();

            List<IdentificationType> identificationTypes = new List<IdentificationType>
            {
                new IdentificationType{ TypeId = 1, Type = "Cedula Ciudadania"},
                new IdentificationType{ TypeId = 2, Type = "Pasaporte"},
                new IdentificationType{ TypeId = 3, Type = "Tarjeta Identidad"}
            };

            entityBuilder.HasData(identificationTypes);
        }
    }
}
