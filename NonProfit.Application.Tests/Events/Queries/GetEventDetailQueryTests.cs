using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NonProfit.Application.Events.Queries.GetEventDetail;
using NonProfit.Domain.Entities;
using NonProfit.Persistence;
using Xunit;

namespace NonProfit.Application.Tests.Events.Queries
{
    public class GetEventDetailQueryTests : IClassFixture<TestFixture>
    {
        private readonly NonProfitContext _context;
        public GetEventDetailQueryTests(TestFixture fixture)
        {
            _context = fixture.Context;
        }
        [Fact]
        public async Task GetEventDetail_returns_eventdetailmodel()
        {
            // Setup
            var testEvent = new Event
            {
                Name = "GetEvent1",
                EventType = new EventType
                {
                    Name = "GetEventType1"
                },
                Address = new Address
                {
                    Address1 = "GetAddress1",
                    City = "GetCity1",
                    State = "GetState1",
                    Country = "GetCountry1",
                    PostalCode = "GetPostalCode1"
                },
                EventSchedule = new EventSchedule
                {
                    StartDateTime = DateTime.Parse("06/15/2019 12:00 PM"),
                    EndDateTime = DateTime.Parse("06/15/2019 01:00 PM"),
                    Repeat = Repeat.Daily
                },
                CreatedAt = DateTime.Now,
                CreatedBy = "TempUser",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "TempUser"
            };

            await _context.Events.AddAsync(testEvent);
            await _context.SaveChangesAsync();

            var handler = new GetEventDetailQueryHandler(_context);
            var result = await handler.Handle(new GetEventDetailQuery { EventId = 1 }, CancellationToken.None);

            result.Should().BeOfType<EventDetailModel>();
            result.EventName.Should().Be("GetEvent1");
            result.EventTypeName.Should().Be("GetEventType1");
        }
    }
}