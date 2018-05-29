using System;

namespace BabysitterKata
{
    public class InputException : Exception
    {
        public InputException(string message) : base(message){}
    }
}