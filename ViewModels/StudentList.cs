using CourseManagement.Models;
using CourseManagement.Services;

namespace CourseManagement.ViewModels
{
    public interface IStudentList
    {
        List<Student> Students { get; }

        void GetAllStudents();
    }

    public class StudentList : IStudentList
    {
        public List<Student> Students { get; private set; }
        private IStudentService StudentService { init; get; }

        public StudentList(IStudentService studentService)
        {
            StudentService = studentService;
        }

        public void GetAllStudents()
            => Students = StudentService.GetAllStudents();
    }
}