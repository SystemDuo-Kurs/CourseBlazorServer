using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface ITeacherList
    {
        List<Teacher> Teachers { get; set; }

        void GetAllTeachers();
    }

    public class TeacherList : ITeacherList
    {
        public List<Teacher> Teachers { get; set; } = new();
        private ITeacherService TeacherService { get; init; }

        public TeacherList(ITeacherService teacherService)
        {
            TeacherService = teacherService;
            GetAllTeachers();
        }

        public void GetAllTeachers() => Teachers = TeacherService.GetTeachers();
    }
}