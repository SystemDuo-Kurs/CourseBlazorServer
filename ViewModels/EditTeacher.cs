using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface IEditTeacher
    {
        Teacher Teacher { get; }

        void SaveTeacher();
    }

    public class EditTeacher : IEditTeacher
    {
        public Teacher Teacher { get; private set; } = new();
        private ITeacherService TeacherService { get; init; }

        public EditTeacher(ITeacherService teacherService)
        {
            TeacherService = teacherService;
        }

        public void SaveTeacher() => TeacherService.UpdateTeacher(Teacher);
    }
}