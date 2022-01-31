using CourseManagement.Data;
using CourseManagement.Models;

namespace CourseManagement.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();

        void UpdateStudent(Student student);

        void DeleteStudent(Student student);
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

        public void UpdateStudent(Student student)
        {
            Db.Update(student);
            Db.SaveChanges();
        }

        public void DeleteStudent(Student student)
        {
            Db.Remove(student);
            Db.SaveChanges();
        }
    }
}