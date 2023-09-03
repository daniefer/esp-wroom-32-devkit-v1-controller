using System;
using System.Device.Gpio;
using System.Diagnostics;
using System.Threading;
using esp32_project1.Board;

namespace esp32_project1
{
    public class Program
    {
        // Board model: ESP32 DEVKIT V1 DOIT
        /*
            To Install flash tools: dotnet tool install -g nanoff
            To Flash: nanoff --platform esp32 --serialport COM5 --update
            Quick start guide to nanoFramework: https://docs.nanoframework.net/content/getting-started-guides/getting-started-managed.html


            Resources:
            - https://docs.platformio.org/en/latest/boards/espressif32/esp32doit-devkit-v1.html#configuration
            - https://randomnerdtutorials.com/getting-started-with-esp32/
            - https://randomnerdtutorials.com/esp32-pinout-reference-gpios/
         */

        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            var relay = ComponentFactory.CreateRelay(InputOutputPin.InputOutputPin32);
            var led = ComponentFactory.CreateLed(BuiltInGpioPin.OnboardBlueLed);

            while(true)
            {
                relay.Toggle();
                led.Toggle();
                Debug.WriteLine("LED State: " + led.LedStateAsString());
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }
    }
}
