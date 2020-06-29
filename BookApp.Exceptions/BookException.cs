using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Exceptions
{
    public class BookException : ApplicationException
    {
        public BookException() { }

        public BookException(string message) : base(message)
        {

        }
    }
}
