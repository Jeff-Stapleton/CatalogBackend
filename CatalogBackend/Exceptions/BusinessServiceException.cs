using System;

namespace CatalogBackend.Exceptions
{
    public class BusinessServiceException : Exception
    {
        public BusinessServiceException() { }
        public BusinessServiceException(string message) : base(message) { }
    }
}
