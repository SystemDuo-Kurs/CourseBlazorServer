using CourseManagement.Data;
using CourseManagement.Models;

namespace CourseManagement.Services
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();

        void UpdateCourse(Course course);

        void DeleteCourse(Course course);
    }

    public class CourseService : ICourseService
    {
        private ApplicationDbContext Db { init; get; }

        public CourseService(ApplicationDbContext db)
        {
            Db = db;
        }

        public List<Course> GetAllCourses()
            => Db.Courses.ToList();

        public void UpdateCourse(Course course)
        {
            Db.Update(course);
            Db.SaveChanges();
        }

        public void DeleteCourse(Course course)
        {
            Db.Remove(course);
            Db.SaveChanges();
        }
    }
}