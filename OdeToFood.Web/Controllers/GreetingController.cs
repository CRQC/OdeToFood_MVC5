using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {



            var model = new GreetingViewModel();
            model.Name = name ?? "no name";

            //var name = HttpContext.Request.QueryString["name"]; setting the context directly. (not adviceble)

            model.Message = ConfigurationManager.AppSettings["message"];
            model.Message = $"{model.Message} -- Return from Controller ";
            return View(model);
        }
    }
}