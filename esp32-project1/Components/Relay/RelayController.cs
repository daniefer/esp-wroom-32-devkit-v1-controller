using System;
using esp32_project1.Components.Led;
using esp32_project1.Exceptions;
using System.Device.Gpio;

namespace esp32_project1.Components.Relay
{
    internal class RelayController
    {
        private GpioPin gpioPin;

        public RelayController(GpioPin gpioPin)
        {
            if (gpioPin is null)
            {
                throw new ArgumentNullException(nameof(gpioPin));
            }
            if (gpioPin.GetPinMode() != PinMode.Output)
            {
                throw new InvalidGpioConfigurationException($"GpioPin must be in Output mode for {typeof(LedController)}");
            }
            this.gpioPin = gpioPin;
            Reset();
        }

        public RelayValue RelayState { get; private set; }

        public void Reset()
        {
            gpioPin.Write(PinValue.Low);
            RelayState = RelayValue.Open;
        }

        public void Closed()
        {
            gpioPin.Write(PinValue.High);
            RelayState = RelayValue.Closed;
        }

        public void Open()
        {
            gpioPin.Write(PinValue.Low);
            RelayState = RelayValue.Open;
        }

        public void Toggle()
        {
            gpioPin.Toggle();
            RelayState = RelayState == RelayValue.Open ? RelayValue.Closed : RelayValue.Open;
        }
    }
}
