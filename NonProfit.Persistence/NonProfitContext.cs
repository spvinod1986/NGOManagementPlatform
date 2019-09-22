using Microsoft.EntityFrameworkCore;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence
{
    public class NonProfitContext : DbContext
    {
        public NonProfitContext(DbContextOptions<NonProfitContext> options)
      : base(options)
        { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventFinancial> EventFinancials { get; set; }
        public DbSet<EventSchedule> EventSchedules { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NonProfitContext).Assembly);
        }

    }
}