using gyakmvc40702.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gyakmvc40702.Controllers
{
    public class HomeController : Controller
    {
        gyakmvc40702Db _db = new gyakmvc40702Db();
        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();


            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Ádám";
            model.Location = "Bátonyterenye";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
