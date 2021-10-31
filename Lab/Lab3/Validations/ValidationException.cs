using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Validations
{
    public class ValidationException : Exception
    {
        public ValidationException() : base() { }
        public ValidationException(string message) : base(message) { }
        public ValidationException(string message, Exception ex) : base(message) { }
    }
}
