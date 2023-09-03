using System;

namespace esp32_project1.Board
{
    internal enum BuiltInGpioPin : int
    {
        /// <summary>
        /// 
        /// Output pin measured 2.6VDC in High state
        /// Output pin measured 0VDC in Low state
        /// </summary>
        OnboardBlueLed = 2,
    }

    internal enum InputOutputPin : int
    {
        /// <summary>
        /// 
        /// Output pin measured 3.1VDC in High state
        /// Output pin measured 0VDC in Low state
        /// </summary>
        InputOutputPin32 = 32,
    }
}
