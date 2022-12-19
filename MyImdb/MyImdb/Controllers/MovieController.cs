using Microsoft.AspNetCore.Mvc;
using MyImdb.Models;
using MyImdb.ViewModels;

namespace MyImdb.Controllers {

	public class MovieController : Controller {

		public IActionResult Index(string msg = null) {
			var movies = Movie.SelectAll().ConvertAll(m => new MovieListViewModel() {
				Rank = m.Rank,
				Title = m.Title,
				Year = m.Year
			});
			ViewBag.Message = msg;
			return View(movies);
		}

		public IActionResult Create() {
			return View();
		}

		[HttpPost]
		public IActionResult Create(MovieCreateViewModel model) {
			if (!ModelState.IsValid) {
				return View(model);
			}
			return RedirectToAction(nameof(Index), new { msg = "Movie created with success." });
		}

		public ActionResult MovieOfTheMonth() {
			return View();
		}

	}

}
