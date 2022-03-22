using CourseMan.Data;
using CourseMan.Models;
using CourseMan.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CourseMan.Controllers
{
    public class InstructorsController : Controller
    {

        private IInstructorRepository repo;
        public InstructorsController(IInstructorRepository repo)
        {

            //this.repo = new InstructorRepository(db);
            this.repo = repo;

        }
        public IActionResult Index(int? InstructorId)
        {
            List<Instructor> instructors = this.repo.GetInstructors();

            if(InstructorId != null)
            {
                
            }


            return View(instructors);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult Create(Instructor instructor)
        {
            if (!ModelState.IsValid)
            {
                return View(instructor);
            }
            TempData["Success"] = "Instructor created";
            this.repo.Save(instructor);
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var instructor = 
            //if (student == null)
            //{
            //    return NotFound();
            //}

            return View();
        }
    }
}
