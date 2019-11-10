using ScheduleInterface;
using System;
using System.Collections.Generic;
using System.Threading;

namespace TimeClock
{
    class TimeClock
    {
        private ITimeClockState State;
        public ISchedule Schedule;

        public TimeClock(ISchedule schedule)
        {
            Schedule = schedule;
            SetStateFromSchedule();
        }

        public void SetState(ITimeClockState state)
        {
            State = state;
        }

        public void Start()
        {
            while (true)
            {
                State.SetHeatingMode(this);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        public void OnBoostStarted()
        {
            SetState(new BoostState());
        }

        public void SetStateFromSchedule()
        {
            var currentTime = DateTime.Now;
            var currentQuarter = currentTime.Minute / 15;

            Dictionary<int, bool> quarters;
            switch (currentTime.DayOfWeek)
            {                
                case DayOfWeek.Sunday:
                    if(Schedule.SundayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                case DayOfWeek.Monday:
                    if (Schedule.MondayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                case DayOfWeek.Tuesday:
                    if (Schedule.TuesdayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                case DayOfWeek.Wednesday:
                    if (Schedule.WednesdayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                case DayOfWeek.Thursday:
                    if (Schedule.ThursdayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                case DayOfWeek.Friday:
                    if (Schedule.FridayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                case DayOfWeek.Saturday:
                    if (Schedule.SaturdayTimes.TryGetValue(currentTime.Hour, out quarters))
                    {
                        TurnHeatingOnIfScheduled(currentQuarter, quarters);
                    }
                    break;
                default:
                    SetState(new Offstate());
                    break;
            }
        }

        private void TurnHeatingOnIfScheduled(int currentQuarter, Dictionary<int, bool> quarters)
        {
            bool heatingShouldBeOn;
            if (quarters.TryGetValue(currentQuarter, out heatingShouldBeOn))
            {
                if (heatingShouldBeOn)
                {
                    SetState(new OnState());
                }
            }
        }
    }
}
