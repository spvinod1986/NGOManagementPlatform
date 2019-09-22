using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence.Configurations
{
    public class EventScheduleConfiguration : IEntityTypeConfiguration<EventSchedule>
    {
        public void Configure(EntityTypeBuilder<EventSchedule> builder)
        {
            builder.Property(e => e.StartDateTime).IsRequired();
            builder.Property(e => e.EndDateTime).IsRequired();
            builder.Property(e => e.Repeat).IsRequired();
        }
    }
}