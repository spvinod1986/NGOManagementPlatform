using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NonProfit.Application.Events.Commands.CreateEvent;
using NonProfit.Domain.Entities;
using NonProfit.Persistence;
using Xunit;

namespace NonProfit.Application.Tests.Events.Commands
{
    public class CreateEventCommandTests : IClassFixture<TestFixture>
    {
        private readonly NonProfitContext _context;
        public CreateEventCommandTests(TestFixture fixture)
        {
            _context = fixture.Context;
        }
        [Fact]
        public async Task CreateEventCommand_creates_event_and_returns_event_id()
        {
            var handler = new CreateEventCommandHandler(_context);

            var newEventId = await handler.Handle(new CreateEventCommand
            {
                EventName = "TestEvent1",
                EventTypeName = "TestEventType",
                Address1 = "TestAddress1",
                Address2 = "TestAddress2",
                City = "TestCity",
                State = "TestState",
                Country = "TestCountry",
                PostalCode = "TestPostalCode",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now,
                Repeat = Repeat.Daily
            }, CancellationToken.None);

            var result = await _context.Events.FindAsync(newEventId);

            result.Id.Should().Be(newEventId);
            result.Name.Should().Be("TestEvent1");
        }
    }

}