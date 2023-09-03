using System;
using System.Device.Gpio;
using System.Reflection;
using esp32_project1.Exceptions;

namespace esp32_project1.Components.Led
{
    internal class LedController
    {
        private GpioPin gpioPin;

        public LedController(GpioPin gpioPin)
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

        public LedState LedState { get; private set; }

        public string LedStateAsString()
        {
            switch (this.LedState)
            {
                case LedState.On:
                    return "On";
                case LedState.Off:
                    return "Off";
                default:
                    throw new NotImplementedException();
            }
        }

        public void Reset()
        {
            gpioPin.Write(PinValue.Low);
            this.LedState = LedState.Off;
        }

        public void TurnOn()
        {
            gpioPin.Write(PinValue.High);
            this.LedState = LedState.On;
        }

        public void TurnOff()
        {
            gpioPin.Write(PinValue.Low);
            this.LedState = LedState.Off;
        }

        public void Toggle()
        {
            this.gpioPin.Toggle();
            this.LedState = this.LedState == LedState.Off ? LedState.On : LedState.Off;
        }
    }
}
