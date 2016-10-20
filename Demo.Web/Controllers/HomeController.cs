using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string CreateLog()
        {
            CinemaEmpire.Data.Entities.SystemLog log = new CinemaEmpire.Data.Entities.SystemLog();
            log.Id = 1;
            log.DateCreated = DateTime.Now;
            log.Message = "Hello Universe";

            CinemaEmpire.Data.Repositories.SystemRepository logRepo = new CinemaEmpire.Data.Repositories.SystemRepository();

            logRepo.CreateLog(log);

            return "Success!";
        }
    }
}