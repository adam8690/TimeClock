using System;
using System.Threading;
using System.Timers;

namespace TimeClock
{
    class BoostState : ITimeClockState
    {
        private bool BoostIsOn;
        public void SetHeatingMode(TimeClock context)
        {
            Console.WriteLine(nameof(BoostState));
            BoostIsOn = true;
            var boostDurationTimeSpan = new TimeSpan(0, context.Schedule.BoostDurationMinutes, 0);
            var boostTimer = new System.Timers.Timer(boostDurationTimeSpan.TotalMilliseconds);
            boostTimer.Enabled = true;
            boostTimer.Elapsed += OnBoostTimerElapsed;

            boostTimer.Start();

            while (BoostIsOn)
            {
                Console.WriteLine("Checking if Boost is On (Should be every second)");
                Thread.Sleep(1000);
                break;
            }

            // Set GPIO Pins here

            context.SetStateFromSchedule();
        }

        private void OnBoostTimerElapsed(Object source, ElapsedEventArgs e)
        {
            BoostIsOn = false;
        }
    }
}
