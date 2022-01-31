using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface IEditStudent
    {
        Student Student { get; set; }

        void SaveStudent();

        void DeleteStudent(Student student);
    }

    public class EditStudent : IEditStudent
    {
        public Student Student { get; set; } = new();
        private IStudentService StudentService { get; init; }

        public EditStudent(IStudentService studentService)
        {
            StudentService = studentService;
        }

        public void SaveStudent() => StudentService.UpdateStudent(Student);

        public void DeleteStudent(Student student) => StudentService.DeleteStudent(student);
    }
}