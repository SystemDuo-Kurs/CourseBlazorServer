using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface ICourseList
    {
        List<Course> Courses { get; }

        void GetAllCourses();
    }

    public class CourseList : ICourseList
    {
        public List<Course> Courses { get; private set; } = new();
        private ICourseService CourseService { init; get; }

        public CourseList(ICourseService courseService)
        {
            CourseService = courseService;
            GetAllCourses();
        }

        public void GetAllCourses()
            => Courses = CourseService.GetAllCourses();
    }
}