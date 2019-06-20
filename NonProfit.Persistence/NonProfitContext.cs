using Microsoft.EntityFrameworkCore;
using NonProfit.Domain.Entities;

namespace NonProfit.Persistence
{
    public class NonProfitContext : DbContext
    {
        public NonProfitContext(DbContextOptions<NonProfitContext> options)
      : base(options)
        { }

        public DbSet<Event> Events { get; set; }

    }
}