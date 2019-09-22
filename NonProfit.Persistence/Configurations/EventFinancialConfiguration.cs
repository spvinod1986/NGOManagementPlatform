using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence.Configurations
{
    public class EventFinancialConfiguration : IEntityTypeConfiguration<EventFinancial>
    {
        public void Configure(EntityTypeBuilder<EventFinancial> builder)
        {
            builder.Property(e => e.Fees).HasColumnType("decimal(8,2)").IsRequired();
            builder.Property(e => e.StartDateTime).IsRequired();
            builder.Property(e => e.EndDateTime).IsRequired();
            builder.Property(e => e.FeeType).IsRequired();
            builder.Property(e => e.EventId).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(20).IsRequired();
            builder.Property(e => e.UpdatedBy).HasMaxLength(20).IsRequired();
        }
    }
}