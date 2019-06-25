using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using NonProfit.Application.Events.Queries.GetEventDetail;
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
            var handler = new GetEventDetailQueryHandler(_context);

            var result = await handler.Handle(new GetEventDetailQuery { Id = 1 }, CancellationToken.None);

            result.Should().BeOfType<EventDetailModel>();
            result.Id.Should().Be(1);
            result.Name.Should().Be("TestEvent1");
        }
    }
}