using System;

namespace ePlatform.Api.Core.Exceptions
{
    public class ForbiddenExcepitons : Exception
    {
        public ForbiddenExcepitons(string message) : base(message)
        {

        }

        public ForbiddenExcepitons(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
