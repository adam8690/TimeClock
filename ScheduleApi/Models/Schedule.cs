using ScheduleInterface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScheduleApi
{
    public class Schedule : ISchedule
    {
        [Required]
        public Dictionary<int, Dictionary<int, bool>> MondayTimes { get; set; }
        [Required]
        public Dictionary<int, Dictionary<int, bool>> TuesdayTimes { get; set; }
        [Required]
        public Dictionary<int, Dictionary<int, bool>> WednesdayTimes { get; set; }
        [Required]
        public Dictionary<int, Dictionary<int, bool>> ThursdayTimes { get; set; }
        [Required]
        public Dictionary<int, Dictionary<int, bool>> FridayTimes { get; set; }
        [Required]
        public Dictionary<int, Dictionary<int, bool>> SaturdayTimes { get; set; }
        [Required]
        public Dictionary<int, Dictionary<int, bool>> SundayTimes { get; set; }
        [Range(10, int.MaxValue)]
        public int BoostDurationMinutes { get; set; } = 15;
    }
}
