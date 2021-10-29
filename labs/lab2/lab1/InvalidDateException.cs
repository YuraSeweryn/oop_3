using System;

namespace lab2
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException() { }

        public InvalidDateException(string message) : base("Date of birth cannot be in future! " + message) { }
        public InvalidDateException(ExceptionData data) : base("Date of birth cannot be in future! " + data.message) { }
        public InvalidDateException(string message, Exception innerException) : base("Date of birth cannot be in future! " + message, innerException) { }
    }

    public class ExceptionData
    {
        public string message;

        public ExceptionData(string message)
        {
            this.message = message;
        }
    }

}
