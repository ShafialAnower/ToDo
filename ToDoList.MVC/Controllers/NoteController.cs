using Microsoft.AspNetCore.Mvc;

namespace ToDoList.MVC.Controllers
{
    public class NoteController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult ViewTask()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}