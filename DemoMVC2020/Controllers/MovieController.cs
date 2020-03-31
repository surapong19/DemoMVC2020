using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC2020.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var db = new Models.AdventureWorksEntities();
            var movie = db.Movie2.ToList();
            return View(movie);
        }

        //public string Index()
        //{
        //    return "Hello";
        //}

        public string Welcome(string name, string id)
        {
            return $"Hello {name}, {id}";
        }
    }
}