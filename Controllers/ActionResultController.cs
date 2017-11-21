using MVCTutorials9AM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM.Controllers
{
    public class ActionResultController : Controller
    {
        // GET: ActionResult
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTableData()
        {
            return PartialView();
        }

        public ActionResult Content()
        {
            return Content("This is content action result");
        }
        public ActionResult Json()
        {
            var studentdata = new StudentVM() { ID = 100, Name = "rama", Email = "rama@gmail.com" };
            return Json(studentdata, JsonRequestBehavior.AllowGet);
        }

        public ActionResult File()
        {
            string filename = "~/Content/flower.jpg";
            return File(filename, MimeMapping.GetMimeMapping(filename));
        }



        /// *
        
        // XML Standard
        //    <student>
        //    <id>100</id>
        //    <name>rama</name>
        //    <email>rama@gmail.com</email>
        //    </student>

        // Json Standard
        // {id:100,name:'rama',email:rama@gmail.com}

        //*/
    }
}