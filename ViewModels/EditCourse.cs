using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface IEditCourse
    {
        Course Course { get; set; }

        void SaveCourse();

        void DeleteCourse(Course course);
    }

    public class EditCourse : IEditCourse
    {
        public Course Course { get; set; } = new();
        private ICourseService CourseService { init; get; }

        public EditCourse(ICourseService courseService)
        {
            CourseService = courseService;
        }

        public void SaveCourse() => CourseService.UpdateCourse(Course);

        public void DeleteCourse(Course course) => CourseService.DeleteCourse(course);
    }
}