using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence.Configurations
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(30).IsRequired();
            builder.Property(e => e.EmailAddress).HasMaxLength(20).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(20).IsRequired();
            builder.Property(e => e.UpdatedBy).HasMaxLength(20).IsRequired();
        }
    }
}