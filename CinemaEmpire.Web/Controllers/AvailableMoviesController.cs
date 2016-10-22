using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaEmpire.Web.Controllers
{
    public class AvailableMoviesController : Controller
    {
        // GET: AvailableMovies
        public ActionResult Index()
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            ViewModels.AvailableMoviesViewModel MovieModels = new ViewModels.AvailableMoviesViewModel();

            IList<Data.Entities.Movie> MovieEntities = new List<Data.Entities.Movie>();

            MovieEntities = cinemaRepo.GetAvailableMovies();

            foreach (var item in MovieEntities)
            {
                ViewModels.Movie Movie = new ViewModels.Movie()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Synopsis = item.Synopsis,
                    ExpectedPopularity = item.ExpectedPopularity,
                    ActualPopularity = item.ActualPopularity,
                    OptimalSeason = item.OptimalSeason,
                    WorstSeason = item.WorstSeason,
                    CostLicense = item.CostLicense,
                    LicenseLength = item.LicenseLength
                };
                MovieModels.Movies.Add(Movie);
            }

            return View(MovieModels);
        }
    }
}