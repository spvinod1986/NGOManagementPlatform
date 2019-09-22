using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence.Configurations
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.EventTypeId).IsRequired();
            builder.Property(e => e.AddressId).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(20).IsRequired();
            builder.Property(e => e.UpdatedBy).HasMaxLength(20).IsRequired();
        }
    }
}