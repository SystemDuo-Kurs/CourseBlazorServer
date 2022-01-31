using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface IEditTeacher
    {
        Teacher Teacher { get; set; }

        void SaveTeacher();

        void DeleteTeacher(Teacher teacher);
    }

    public class EditTeacher : IEditTeacher
    {
        public Teacher Teacher { get; set; } = new();
        private ITeacherService TeacherService { get; init; }

        public EditTeacher(ITeacherService teacherService)
        {
            TeacherService = teacherService;
        }

        public void SaveTeacher() => TeacherService.UpdateTeacher(Teacher);

        public void DeleteTeacher(Teacher teacher) => TeacherService.DeleteTeacher(teacher);
    }
}