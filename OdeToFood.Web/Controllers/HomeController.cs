using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Data;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Controllers
{
    public class HomeController : Controller
    {

        IRestaurantData db;

        public HomeController(IRestaurantData db) 
        {

            this.db = db;
            //db = new InMemoryRestaurantData();
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
            //return View();
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
    }
}