using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieTracker.Models;

namespace MovieTracker.Controllers
{


    public class MoviesController : Controller
    {

        private static List<Movie> movies = new List<Movie>
        {

            new Movie
            {
                MovieId = 1,
                Title = "Car Chases and Explosions",
                DateSeen= DateTime.Now.AddDays(-50),
                Genre = "Action",
                MyRating= 6
            },            new Movie
            {
                MovieId = 2,
                Title = "Silly Misunderstanding",
                DateSeen= DateTime.Now.AddDays(-25),
                Genre = "Action",
                MyRating= 6
            },            new Movie
            {
                MovieId = 1,
                Title = "Serious Discussions",
                DateSeen= DateTime.Now.AddDays(-50),
                Genre = "Action",
                MyRating= 6
            },            new Movie
            {
                MovieId = 1,
                Title = "Car Chases and Explosions",
                DateSeen= DateTime.Now.AddDays(-50),
                Genre = "Action",
                MyRating= 6
            },            new Movie
            {
                MovieId = 1,
                Title = "Car Chases and Explosions",
                DateSeen= DateTime.Now.AddDays(-50),
                Genre = "Action",
                MyRating= 6
            },            new Movie
            {
                MovieId = 1,
                Title = "Car Chases and Explosions",
                DateSeen= DateTime.Now.AddDays(-50),
                Genre = "Action",
                MyRating= 6
            }
            };





        // GET: MoviesController
        public ActionResult Index()
        {
            return View(movies);
        }

        // GET: MoviesController/Details/5
        public ActionResult Details(int id)
        {
            var movie = movies.Find(m  => m.MovieId == id);
            return View();
        }

        // GET: MoviesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    movies.Add(movie);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(movie);
                }
   
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoviesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoviesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
