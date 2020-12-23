using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Exceptions
{
    class BadInputException : ApplicationException
    {
       
        public BadInputException(string message) : base(message)
        {}
    }
}
