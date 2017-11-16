using MVCTutorials9AM.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM.Controllers
{

    public class TestController : Controller
    {
        public string ShowMessage(int id = 0, string id1 = "")
        {
            // string parameter = RouteData.Values["id"].ToString();
            return string.Format("This is Fist MVC action method with id:{0} and id1:{1}", id, id1);
        }
        public string ShowMessage2()
        {
            return "This is second showmessage";
        }
        public string GetEmployee(int id)
        {
            return "employee details of :" + id;
        }

        [LogActionFilter]
        public ActionResult GetHTML(int id = 1)
        {
            if (id == 1)
            {
                ViewBag.Title = "GetHTML Page";
                ViewData["Name"] = "Pragim Tech";
                ViewData["Date"] = DateTime.Now;

                ViewBag.Name = "Pragim Tech";
                ViewBag.Date = DateTime.Now;


                ViewBag.TDataSample = TempData["TData"];

                return View();
            }
            else
            {
                return RedirectToAction("GetHTML1");
            }
        }

        public ActionResult GetHTML1()
        {
            ViewBag.Title = "HTML1 Page";
            TempData["TData"] = "This is Temp Data";
            //ViewBag.TData= "This is Temp Data"; 
            // return RedirectToAction("GetHTML");

            int val = 0;
            int cal = 10 / val;

            return View();
        }

        [OutputCache(Duration = 10)]
        public string ShowDateTime()
        {
            return DateTime.Now.ToString();
        }

        // Base & Derived

        // Base b=new Base();
        // Derived d= new Derived();

        // Base b=new Derived();
        // ActionResult a=new ViewResult();
        // ActionResult ab= new PartialViewResult();

        // Derived d=new Base();



    }


}