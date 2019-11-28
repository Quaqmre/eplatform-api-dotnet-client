using System;
using System.Collections.Generic;
using System.Text;

namespace ePlatform.Api.Core.Exceptions
{
    public class UnauthorizedExcepiton : Exception
    {
        public UnauthorizedExcepiton(string message) : base(message)
        {

        }

        public UnauthorizedExcepiton(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
