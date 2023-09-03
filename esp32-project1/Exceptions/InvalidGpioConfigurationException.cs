using System;

namespace esp32_project1.Exceptions
{
    internal class InvalidGpioConfigurationException : Exception
    {
        public InvalidGpioConfigurationException()
        {
        }

        public InvalidGpioConfigurationException(string message) : base(message)
        {
        }

        public InvalidGpioConfigurationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
