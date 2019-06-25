
using System;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NonProfit.Application.Events.Commands.CreateEvent;
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
        public async Task CreateEventCommand_returns_eventdetailmodel()
        {
            var handler = new CreateEventCommandHandler(_context);

            var newEventId = await handler.Handle(new CreateEventCommand
            {
                Name = "TestEvent3",
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now.AddDays(1)
            }, CancellationToken.None);

            var result = await _context.Events.FindAsync(newEventId);

            result.Id.Should().Be(newEventId);
            result.Name.Should().Be("TestEvent3");
        }
    }

}