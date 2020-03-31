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
            return View();
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