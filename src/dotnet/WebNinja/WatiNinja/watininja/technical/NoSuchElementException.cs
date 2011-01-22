using System;

namespace WatiNinja.watininja.technical
{
    public class NoSuchElementException : Exception
    {
        public NoSuchElementException(string message) :base(message)
        {
        }
    }
}
