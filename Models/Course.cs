namespace CourseManagement.Models
{
    public class Course
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;

        public TimeSpan Duration { get; set; }

        public TimeOnly StartingTime
        {
            get => TimeOnly.FromTimeSpan(StartingTimeDb);
            set => StartingTimeDb = value.ToTimeSpan();
        }

        public TimeSpan StartingTimeDb { set; get; }

        public TimeOnly EndingTime => StartingTime.AddHours(Duration.TotalHours);

        public DateOnly? StartingDate
        {
            get => StartingDateDb is null ? null : DateOnly.FromDateTime(StartingDateDb!.Value);
            set => StartingDateDb = value is null ? null : value.Value.ToDateTime(new TimeOnly());
        }

        public DateTime? StartingDateDb { set; get; }

        public DateOnly? EndingDate
        {
            get => EndingDateDb is null ? null : DateOnly.FromDateTime(EndingDateDb!.Value);
            set => EndingDateDb = value is null ? null : value.Value.ToDateTime(new TimeOnly());
        }

        public DateTime? EndingDateDb { set; get; }

        public List<DoW> DayOfWeek { get; set; } = new();

        public Teacher? Teacher { get; set; }
        public List<Student> Students { get; set; } = new();
    }
}