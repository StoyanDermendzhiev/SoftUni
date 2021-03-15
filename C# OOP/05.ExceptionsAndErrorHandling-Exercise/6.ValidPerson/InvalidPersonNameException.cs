using System;
using System.Collections.Generic;
using System.Text;

namespace _6.ValidPerson
{
    class InvalidPersonNameException : ArgumentException
    {
        public InvalidPersonNameException(string message, string paramName)
            : base(message, paramName)
        {
        }
    }
}
