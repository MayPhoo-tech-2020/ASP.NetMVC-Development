using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(string txt)
        {
            return Content("Indexing ");
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "ReleaseDate" + month);
        }


    }
}