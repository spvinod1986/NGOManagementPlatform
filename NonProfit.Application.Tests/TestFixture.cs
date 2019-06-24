using System;
using NonProfit.Persistence;

namespace NonProfit.Application.Tests
{
    public class TestFixture : IDisposable
    {
        public NonProfitContext Context { get; private set; }

        public TestFixture()
        {
            Context = NonProfitContextFactory.Create();

        }
        void IDisposable.Dispose()
        {
            NonProfitContextFactory.Destroy(Context);
        }
    }
}