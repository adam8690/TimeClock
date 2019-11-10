using System;

namespace TimeClock
{
    class BoostState : IBoilerState
    {
        public void CheckTime(TimeClock context)
        {
            Console.WriteLine(nameof(Offstate));
            // Check if boost has been cancelled
            // Check if boos duration has elapsed

            // Go back to either OnState or OffState depending on current time. 
            context.SetStateFromSchedule();
        }
    }
}
