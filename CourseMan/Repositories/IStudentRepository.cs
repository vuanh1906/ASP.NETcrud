using CourseMan.Models;

namespace CourseMan.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
        Student? GetStudentById(string id);
    }
}