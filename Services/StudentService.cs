using CourseManagement.Data;
using CourseManagement.Models;

namespace CourseManagement.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();

        void UpdateStudent(Student s);
    }

    public class StudentService : IStudentService
    {
        private ApplicationDbContext Db { init; get; }

        public StudentService(ApplicationDbContext db)
        {
            Db = db;
        }

        public List<Student> GetAllStudents()
            => Db.Students.ToList();

        public void UpdateStudent(Student s)
        {
            Db.Update(s);
            Db.SaveChanges();
        }
    }
}