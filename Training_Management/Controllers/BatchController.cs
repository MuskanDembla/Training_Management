using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Training_Management.Models;

namespace Training_Management.Controllers
{
    public class BatchController : Controller
    {
        BatchInterface _repo;
        CourseInterface _repo1;
        public BatchController(BatchInterface repo, CourseInterface repo1)
        {
            _repo = repo;
            _repo1 = repo1;
        }
        public IActionResult Index()
        {
            return View(_repo.GetBatches());
        }
        public IActionResult Create()
        {
            ViewData["Courses"] = new SelectList(_repo1.GetCourses(), "CourseId", "CourseName");

            return View();
        }
        [HttpPost]
        public IActionResult Create(Batch  batch)
        {
            _repo.Create(batch);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Batch obj = _repo.GetBatchById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(int id, Batch batch)
        {
            _repo.Edit(id, batch);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Batch obj = _repo.GetBatchById(id);
            return View(obj);
        }
    }
}
