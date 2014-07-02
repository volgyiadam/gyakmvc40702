using gyakmvc40702.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gyakmvc40702.Controllers
{
    //[Authorize]
    [Log]
    public class CuisineController : Controller
    {
        
        
         
        public ActionResult Search(string name = "french")
        {

            throw new Exception("Something terrible has happened");

            var message = Server.HtmlEncode(name);

            return Content(message);
        }



    }
}
