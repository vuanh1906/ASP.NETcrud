using CourseMan.Models;

namespace CourseMan.Repositories
{
    public interface IInstructorRepository
    {
        List<Instructor> GetInstructors();
        bool Save(Instructor instructor);
    }
}