using System;
using System.Collections.Generic;

namespace StatePattern
{
    class TimeClock
    {
        private IBoilerState State;
        private List<DateTime> Schedule;
        private TimeSpan BoostDuration;

        public TimeClock(List<DateTime> schedule, TimeSpan boostDuration)
        {
            Schedule = schedule;
            BoostDuration = boostDuration;
            SetStateFromSchedule();
        }

        public void CheckTime()
        {
            State.CheckTime(this);
        }

        public void Boost()
        {
            SetState(new BoostState());
        }

        public void SetStateFromSchedule()
        {
            // TODO check current time and compare to schedule, then determine if the boiler should be off or on. 
            State = new Offstate();
        }

        public void SetState(IBoilerState state)
        {
            // TODO check current time and compare to schedule, then determine if the boiler should be off or on. 
            State = state;
        }
    }
}
