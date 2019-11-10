using ScheduleInterface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScheduleApi
{
    public class Schedule : ISchedule
    {
        [Required]
        public Dictionary<int, int> MondayTimes { get; set; }
        [Required]
        public Dictionary<int, int> TuesdayTimes { get; set; }
        [Required]
        public Dictionary<int, int> WednesdayTimes { get; set; }
        [Required]
        public Dictionary<int, int> ThursdayTimes { get; set; }
        [Required]
        public Dictionary<int, int> FridayTimes { get; set; }
        [Required]
        public Dictionary<int, int> SaturdayTimes { get; set; }
        [Required]
        public Dictionary<int, int> SundayTimes { get; set; }
    }
}
