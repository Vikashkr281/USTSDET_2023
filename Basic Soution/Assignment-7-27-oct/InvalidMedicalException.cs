﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_27_oct
{
    internal class InvalidMedicalException : Exception
    {
        public InvalidMedicalException(string message) : base( message)
        { }
    }
}
