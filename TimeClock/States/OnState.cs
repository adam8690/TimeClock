using System;
using System.Threading;

namespace TimeClock
{
    class OnState : ITimeClockState
    {
        public void SetHeatingMode(TimeClock context)
        {
            Console.WriteLine(nameof(OnState));



            context.SetState(new Offstate());
        }
    }
}
