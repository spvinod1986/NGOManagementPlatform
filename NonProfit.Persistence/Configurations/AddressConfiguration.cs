using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(e => e.Address1).HasMaxLength(60).IsRequired();
            builder.Property(e => e.Address2).HasMaxLength(60);
            builder.Property(e => e.City).HasMaxLength(15).IsRequired();
            builder.Property(e => e.State).HasMaxLength(15).IsRequired();
            builder.Property(e => e.Country).HasMaxLength(15).IsRequired();
            builder.Property(e => e.PostalCode).HasMaxLength(10).IsRequired();
        }
    }
}