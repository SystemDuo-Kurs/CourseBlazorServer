using CourseManagement.Data;
using CourseManagement.Models;

namespace CourseManagement.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetTeachers();

        void UpdateTeacher(Teacher teacher);

        void DeleteTeacher(Teacher teacher);
    }

    public class TeacherService : ITeacherService
    {
        private ApplicationDbContext Db { get; init; }

        public TeacherService(ApplicationDbContext db)
        {
            Db = db;
        }

        public List<Teacher> GetTeachers()
        {
            var temp = Db.Teachers.ToList();
            return temp is not null ? temp : new List<Teacher>();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            Db.Update(teacher);
            Db.SaveChanges();
        }

        public void DeleteTeacher(Teacher teacher)
        {
            Db.Remove(teacher);
            Db.SaveChanges();
        }
    }
}