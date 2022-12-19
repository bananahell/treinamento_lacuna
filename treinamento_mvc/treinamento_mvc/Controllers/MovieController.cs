using Microsoft.AspNetCore.Mvc;
using treinamento_mvc.Models;
using treinamento_mvc.ViewModels;

namespace treinamento_mvc.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movies = Movie.SelectAll().ConvertAll(m => new MovieListViewModel()
            {
                Rank = m.Rank,
                Title = m.Title,
                Year = m.Year
            });
            return View(movies);
        }

        public ActionResult MovieOfTheMonth()
        {
            return View();
        }
    }
}
