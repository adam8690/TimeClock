using System;

namespace TimeClock
{
    class Offstate : ITimeClockState
    {
        public void SetHeatingMode(TimeClock context)
        {
            Console.WriteLine(nameof(Offstate));
            
            // loop here
            
            // Check for boost mode. Cancellation token? 
            // context.SetState(Boost);

            // check for if it is time for boiler to switch on
            context.SetState(new OnState());
        }
    }
}
