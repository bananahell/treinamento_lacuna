using Microsoft.AspNetCore.Mvc;

namespace treinamento_mvc.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult MovieOfTheMonth()
        {
            return View();
        }
    }
}
