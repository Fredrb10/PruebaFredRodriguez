using Booking.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.Persistence.Database.Configuration
{
    public class CustomerConfiguration
    {
        public CustomerConfiguration(EntityTypeBuilder<Customer> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.DocumentNumber).IsRequired();
            entityBuilder.Property(x => x.DocumentType).IsRequired();
            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.LastName).IsRequired();

            List<Customer> customer = new List<Customer>
            {
                new Customer {Id = 1, DocumentType = 1, DocumentNumber = 102078256, Name = "Juan", LastName = "Perez", Birthdate = DateTime.Now, Gender = "M", 
                               Email = "Juan.P@hotmail.com", Phone="3135026", EmergencyContact = "Maria Rodriguez", EmergencyContactPhone = "5256024"},
                new Customer {Id = 2, DocumentType = 1, DocumentNumber = 17896582, Name = "Sofia", LastName = "Garces", Birthdate = DateTime.Now, Gender = "F",
                               Email = "JuanA.G@hotmail.com", Phone="258782", EmergencyContact = "Carlos Rodriguez", EmergencyContactPhone = "8956225"}
            };
            entityBuilder.HasData(customer);

        }

    }
}
