using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaEmpire.Web.Controllers
{
    public class MovieController : Controller
    {
        /// <summary> Action that compiles and displays all attributes of a single movie (by Id) into text fields for editing.</summary>
        /// GET: Movie/Details
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Create()
        {
            ViewBag.Title = "Create";
            return View();
        }
        /// <summary> Action that submits user edits to movie in the database (by Id) </summary>
        /// POST: Movie/EditSubmit
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateSubmit(FormCollection collection)
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";

            try
            {
                string title = collection.Get("Title");
                string synopsis = collection.Get("Synopsis");
                float expectedPopularity = float.Parse(collection.Get("ExpectedPopularity"), culture);
                float actualPopularity = float.Parse(collection.Get("ActualPopularity"), culture);
                int optimalSeason = Int32.Parse(collection.Get("OptimalSeason"));
                int worstSeason = Int32.Parse(collection.Get("WorstSeason"));
                float costLicense = float.Parse(collection.Get("CostLicense"), culture);
                int licenseLength = Int32.Parse(collection.Get("LicenseLength"));

                cinemaRepo.CreateMovie(title, synopsis, expectedPopularity, actualPopularity, optimalSeason, worstSeason, costLicense, licenseLength);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return RedirectToAction("List");
        }
        /// <summary> Action that compiles and displays the full list of all movies in the database. </summary>
        /// GET: Movie/List
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult List()
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            ViewModels.ListViewModel MovieModels = new ViewModels.ListViewModel();

            IList<Data.Entities.Movie> MovieEntities = new List<Data.Entities.Movie>();

            MovieEntities = cinemaRepo.GetListOfMovies();

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
                    LicenseLength = item.LicenseLength,
                    DateCreated = item.DateCreated,
                    DateModified = item.DateModified
                };
                MovieModels.Movies.Add(Movie);
            }

            return View(MovieModels);
        }
        /// <summary> Action that compiles and displays all attributes of a single movie (by Id) </summary>
        /// GET: Movie/Details
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(string id)
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            Data.Entities.Movie Entity = new Data.Entities.Movie();

            Entity = cinemaRepo.GetMovie(id);

            ViewModels.DetailsViewModel Model = new ViewModels.DetailsViewModel();

            Model.movie.Id = Entity.Id;
            Model.movie.Title = Entity.Title;
            Model.movie.Synopsis = Entity.Synopsis;
            Model.movie.ExpectedPopularity = Entity.ExpectedPopularity;
            Model.movie.ActualPopularity = Entity.ActualPopularity;
            Model.movie.OptimalSeason = Entity.OptimalSeason;
            Model.movie.WorstSeason = Entity.WorstSeason;
            Model.movie.CostLicense = Entity.CostLicense;
            Model.movie.LicenseLength = Entity.LicenseLength;
            Model.movie.DateCreated = Entity.DateCreated;
            Model.movie.DateModified = Entity.DateModified;

            return View(Model);
        }
        /// <summary> Action that compiles and displays all attributes of a single movie (by Id) into text fields for editing.</summary>
        /// GET: Movie/Details
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Edit(string id)
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            Data.Entities.Movie Entity = new Data.Entities.Movie();

            Entity = cinemaRepo.GetMovie(id);

            ViewModels.DetailsViewModel Model = new ViewModels.DetailsViewModel();

            Model.movie.Id = Entity.Id;
            Model.movie.Title = Entity.Title;
            Model.movie.Synopsis = Entity.Synopsis;
            Model.movie.ExpectedPopularity = Entity.ExpectedPopularity;
            Model.movie.ActualPopularity = Entity.ActualPopularity;
            Model.movie.OptimalSeason = Entity.OptimalSeason;
            Model.movie.WorstSeason = Entity.WorstSeason;
            Model.movie.CostLicense = Entity.CostLicense;
            Model.movie.LicenseLength = Entity.LicenseLength;
            Model.movie.DateCreated = Entity.DateCreated;
            Model.movie.DateModified = Entity.DateModified;

            return View(Model);
        }
        /// <summary> Action that submits user edits to movie in the database (by Id) </summary>
        /// POST: Movie/EditSubmit
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditSubmit(string id, FormCollection collection)
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";

            try
            {
                string title = collection.Get("Title");
                string synopsis = collection.Get("Synopsis");
                float expectedPopularity = float.Parse(collection.Get("ExpectedPopularity"), culture);
                float actualPopularity = float.Parse(collection.Get("ActualPopularity"), culture);
                int optimalSeason = Int32.Parse(collection.Get("OptimalSeason"));
                int worstSeason = Int32.Parse(collection.Get("WorstSeason"));
                float costLicense = float.Parse(collection.Get("CostLicense"), culture);
                int licenseLength = Int32.Parse(collection.Get("LicenseLength"));

                cinemaRepo.EditMovie(id, title, synopsis, expectedPopularity, actualPopularity, optimalSeason, worstSeason, costLicense, licenseLength);
            }
            catch(Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return RedirectToAction("Edit/" + id);
        }
        /// <summary> Action that deletes from the database a movie (by Id) </summary>
        /// DELETE: Movie/Delete
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(string id)
        {
            Data.Repositories.CinemaRepository cinemaRepo = new Data.Repositories.CinemaRepository();

            cinemaRepo.DeleteMovie(id);

            return RedirectToAction("List");
        }
    }
}