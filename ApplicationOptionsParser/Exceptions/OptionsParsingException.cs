using System;

namespace ApplicationOptionsParser.Exceptions
{
    public class OptionsParsingException : Exception
    {
        public OptionsParsingException(string msg) : base(msg)
        {

        }
    }
}
