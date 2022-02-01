using System;

namespace VendasControle.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base( message)
        {
                
        }
    }
}
