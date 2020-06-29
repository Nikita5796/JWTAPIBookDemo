﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Exceptions
{
    public class UserException : ApplicationException
    {
        public UserException() { }

        public UserException(string message) : base(message)
        {

        }
    }
}
