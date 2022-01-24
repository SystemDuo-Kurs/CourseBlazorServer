namespace CourseManagement.Models
{
    public class Course
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = string.Empty;

        public TimeSpan Duration { get; set; }

        public TimeOnly StartingTime
        {
            get => TimeOnly.Parse(StartingTimeDB);
            set => StartingTimeDB = value.ToString();
        }

        public string StartingTimeDB { set; get; } = string.Empty;

        public TimeOnly EndingTime { get => StartingTime.AddHours(Duration.TotalHours); }

        public DateOnly StartingDate
        {
            get => DateOnly.Parse(StartingDateDB);
            set => StartingDateDB = value.ToString();
        }

        public string StartingDateDB { set; get; } = string.Empty;

        public DateOnly EndingDate
        {
            get => DateOnly.Parse(EndingDateDB);
            set => EndingDateDB = value.ToString();
        }

        public string EndingDateDB { set; get; } = string.Empty;
        public List<DoW> DayOfWeek { get; set; } = new();
    }
}