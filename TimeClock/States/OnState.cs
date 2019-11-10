using System;

namespace TimeClock
{
    class OnState : IBoilerState
    {
        public void CheckTime(TimeClock context)
        {
            Console.WriteLine(nameof(OnState));
            // loop here

            // Check for boost mode. Cancellation token? 
            // context.SetState(Boost);

            // check for if it is time for boiler to switch off
            context.SetState(new Offstate());
        }
    }
}
