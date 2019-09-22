using System;
using Microsoft.EntityFrameworkCore;
using NonProfit.Domain.Entities;
using NonProfit.Persistence;

namespace NonProfit.Application.Tests
{
    public class NonProfitContextFactory
    {
        public static NonProfitContext Create()
        {
            var options = new DbContextOptionsBuilder<NonProfitContext>()
                .UseSqlite(TestSetting.ConnectionString)
                .Options;

            var context = new NonProfitContext(options);

            context.Database.OpenConnection();
            context.Database.EnsureCreated();

            // context.Events.AddRange(new[] {
            //     new Event { Id = 1, Name = "TestEvent1", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now},
            //     new Event { Id = 2, Name = "TestEvent1", StartDateTime = DateTime.Now, EndDateTime = DateTime.Now},
            // });

            context.SaveChanges();

            return context;
        }

        public static void Destroy(NonProfitContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}