using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM.Controllers
{
    public class CarHomeController : Controller
    {
       
        // GET: CarHome
        public ActionResult Index()
        {
            return View();
        }
    }
}