using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface ITeacherList
    {
        List<Teacher> Teachers { get; }

        void GetTeachers();
    }

    public class TeacherList : ITeacherList
    {
        public List<Teacher> Teachers { get; private set; } = new();
        private ITeacherService TeacherService { get; init; }

        public TeacherList(ITeacherService teacherService)
        {
            TeacherService = teacherService;
            GetTeachers();
        }

        public void GetTeachers() => Teachers = TeacherService.GetTeachers();
    }
}