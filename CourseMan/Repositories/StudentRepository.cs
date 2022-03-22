using CourseMan.Data;
using CourseMan.Models;

namespace CourseMan.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public List<Student> GetAllStudents()
        {
            return db.Student.ToList();
        }
        public Student? GetStudentById(string id)
        {
            return db.Student.FirstOrDefault(s => s.StudentId == id);
        }
    }
}
