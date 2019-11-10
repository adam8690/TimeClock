using ScheduleInterface;
using System.Collections.Generic;

namespace TimeClock
{
    public class Schedule : ISchedule
    {
        public Dictionary<int, Dictionary<int, bool>> MondayTimes { get; set; }
        public Dictionary<int, Dictionary<int, bool>> TuesdayTimes { get; set; }
        public Dictionary<int, Dictionary<int, bool>> WednesdayTimes { get; set; }
        public Dictionary<int, Dictionary<int, bool>> ThursdayTimes { get; set; }
        public Dictionary<int, Dictionary<int, bool>> FridayTimes { get; set; }
        public Dictionary<int, Dictionary<int, bool>> SaturdayTimes { get; set; }
        public Dictionary<int, Dictionary<int, bool>> SundayTimes { get; set; }
        public int BoostDurationMinutes { get; set; }
    }
}
