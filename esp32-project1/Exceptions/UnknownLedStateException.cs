using System;
using System.Device.Gpio;

namespace esp32_project1.Exceptions
{
    internal class UnknownLedStateException : Exception
    {
        public UnknownLedStateException(PinValue value) : this($"Pin has unknown value: {(int)value}")
        {
        }

        public UnknownLedStateException(string message) : base(message)
        {
        }

        public UnknownLedStateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
