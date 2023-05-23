using Microsoft.AspNetCore.Mvc;
using Training_Management.Models;

namespace Training_Management.Controllers
{
    public class CourseController : Controller
    {
        CourseInterface __repo;
        public CourseController(CourseInterface repo)
        {
            __repo = repo;
        }
        public IActionResult Index()
        {
            return View(__repo.GetCourses());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            __repo.Create(course);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Course obj = __repo.GetCourseById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(int id, Course course)
        {
            __repo.Edit(id, course);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Course obj = __repo.GetCourseById(id);
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            Course obj = __repo.GetCourseById(id);
            return View(obj);
        }



        [HttpPost]
        public IActionResult Deleted(int CourseId)
        {
            __repo.Delete(CourseId);
            return RedirectToAction("index");
        }
    }
}
