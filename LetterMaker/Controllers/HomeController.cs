using Microsoft.AspNetCore.Mvc;

namespace LetterMaker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
