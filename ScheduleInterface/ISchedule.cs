using System.Collections.Generic;

namespace ScheduleInterface
{
    public interface ISchedule
    {
        public Dictionary<int, int> MondayTimes { get; set; }
        public Dictionary<int, int> TuesdayTimes { get; set; }
        public Dictionary<int, int> WednesdayTimes { get; set; }
        public Dictionary<int, int> ThursdayTimes { get; set; }
        public Dictionary<int, int> FridayTimes { get; set; }
        public Dictionary<int, int> SaturdayTimes { get; set; }
        public Dictionary<int, int> SundayTimes { get; set; }
    }
}
