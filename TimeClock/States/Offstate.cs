using System;

namespace TimeClock
{
    class Offstate : IBoilerState
    {
        public void CheckTime(TimeClock context)
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
