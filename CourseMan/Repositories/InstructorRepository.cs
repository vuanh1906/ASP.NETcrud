using CourseMan.Data;
using CourseMan.Models;

namespace CourseMan.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        private ApplicationDbContext db;

        public InstructorRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public List<Instructor> GetInstructors()
        {
            return db.Instructor.ToList();
        }
        //Notify success

        public bool Save(Instructor instructor)
        {

            db.Instructor.Add(instructor);
            db.SaveChanges();
            return true;
        }
    }
}
