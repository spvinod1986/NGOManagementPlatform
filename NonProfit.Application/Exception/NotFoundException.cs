using System;

namespace NonProfit.Application.Exception
{
    public class NotFoundException : SystemException
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}