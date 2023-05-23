using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Training_Management.Models;

namespace Training_Management.Controllers
{
    public class UserController : Controller
    {
        UserInterface _repo;

        public UserController(UserInterface repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetUsers());
        }
        public IActionResult Create()
        {
            ViewData["ManagerName"] =
            new SelectList(_repo.GetUsers().Where(x => (int)x.Role == 1).ToList(),
            "UserId", "USerName"
            );

            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _repo.Create(user);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["ManagerName"] =
            new SelectList(_repo.GetUsers().Where(x => (int)x.Role == 1).ToList(),
            "UserId", "USerName"
            );

            return View();
        }
        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            _repo.Edit(id, user);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            User obj = _repo.GetUserById(id);
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            User obj = _repo.GetUserById(id);
            return View(obj);
        }



        [HttpPost]
        public IActionResult Deleted(int UserId)
        {
            _repo.Delete(UserId);
            return RedirectToAction("index");
        }

        public IActionResult Validate()
        {
            return View();
        }
        public IActionResult Index1()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Validate(string Email, string Password)
        {
            var user = _repo.ValidateUser(Email, Password);
            if (user != null)
            {
                if ((int)user.Role == 0)
                {
                    return RedirectToAction("Index");
                }
                else if ((int)user.Role== 1)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Validate");
            }
        }
    }


}
