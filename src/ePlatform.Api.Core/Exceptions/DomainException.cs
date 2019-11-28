using System;
using System.Collections.Generic;

namespace ePlatform.Api.Core.Exceptions
{
    public class DomainException : Exception
    {
        public Dictionary<string, IEnumerable<string>> Details { get; }


        public DomainException(Dictionary<string, IEnumerable<string>> details, string message) : base(message)
        {
            Details = details;
        }

        public DomainException(Dictionary<string, IEnumerable<string>> details, string message, Exception innerException) : base(message, innerException)
        {
            Details = details;
        }
    }
}
