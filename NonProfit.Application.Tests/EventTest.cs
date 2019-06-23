using System;
using System.Linq;
using FluentAssertions;
using NonProfit.Persistence;
using Xunit;

namespace NonProfit.Application.Tests
{
    public class EventTest : IClassFixture<TestFixture>
    {
        NonProfitContext context;
        public EventTest(TestFixture fixture)
        {
            this.context = fixture.Context;
        }
        [Fact]
        public void SampleTest()
        {
            var result = context.Events.ToList();

            result.Count.Should().Be(2);

        }
    }
}
