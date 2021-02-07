using System;

namespace Bootcamp_3_1.Ordering.Domain.CustomExceptions

{
    public class DatabaseAccessException : Exception
    {
        public DatabaseAccessException()
        {
        }

        public DatabaseAccessException(string message) : base(message)
        {
        }

        public DatabaseAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}