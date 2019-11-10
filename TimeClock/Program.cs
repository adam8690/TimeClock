using System;
using System.Collections.Generic;

namespace TimeClock
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = new Schedule();
            var timeClock = new TimeClock(schedule);
            timeClock.Start();
        }
    }
}
