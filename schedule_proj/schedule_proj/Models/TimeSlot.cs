namespace schedule_proj.Models
{
    public class TimeSlot
    {
        public int Id { get; set; } 
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; } 
        public DayOfWeek DayOfWeek { get; set; } 
    }
}
