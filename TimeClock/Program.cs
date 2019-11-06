﻿using System;
using System.Collections.Generic;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var schedule = new List<DateTime>();
            var boostDuration = new TimeSpan();
            var boiler = new TimeClock(schedule, boostDuration);
            boiler.CheckTime();
        }
    }
}