using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence.Configurations
{
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.Property(e => e.EventId).IsRequired();
            builder.Property(e => e.UserProfileId).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(20).IsRequired();
            builder.Property(e => e.UpdatedBy).HasMaxLength(20).IsRequired();
        }
    }
}