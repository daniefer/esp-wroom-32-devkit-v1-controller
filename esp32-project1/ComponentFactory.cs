using System;
using System.Device.Gpio;
using esp32_project1.Board;
using esp32_project1.Components.Led;
using esp32_project1.Components.Relay;

namespace esp32_project1
{

    internal static class ComponentFactory
    {
        private static GpioController GPIO = new GpioController(PinNumberingScheme.Logical);

        public static LedController CreateLed(BuiltInGpioPin pin)
        {
            return new LedController(GPIO.OpenPin((int)pin, PinMode.Output));
        }

        public static RelayController CreateRelay(InputOutputPin pin)
        {
            return new RelayController(GPIO.OpenPin((int)pin, PinMode.Output));
        }
    }
}
