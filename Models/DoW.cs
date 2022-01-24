namespace CourseManagement.Models
{
    public class DoW
    {
        public int Id { get; set; }
        public DayOfWeek DayOfWeek { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}