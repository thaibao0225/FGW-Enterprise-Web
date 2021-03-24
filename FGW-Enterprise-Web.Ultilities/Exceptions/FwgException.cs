using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Ultilities.Exceptions
{
    public class FwgException : Exception
    {
        public FwgException()
        {
        }

        public FwgException(string message)
            : base(message)
        {
        }
        public FwgException(string message, Exception inner)
           : base(message, inner)
        {
        }
    }
}
