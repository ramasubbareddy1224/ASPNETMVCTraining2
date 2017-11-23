using MVCTutorials9AM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM.Controllers
{
    public class CarMakerController : Controller
    {
        // CMSDBContext dbContext = new CMSDBContext();
        // GET: CarMaker
        public ActionResult Index()
        {
            List<CarMaker> makerList;
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                makerList = dbContext.CarMaker.ToList();
            }
            return View(makerList);
        }
        public ActionResult Detail(int id)
        {
            CarMaker maker;
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                maker = dbContext.CarMaker.Find(id);
            }
            return View(maker);
        }

        public ActionResult Create()
        {
            return View(new CarMaker());
        }

        [HttpPost]
        public ActionResult Create(CarMaker makerVM)
        {
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                dbContext.CarMaker.Add(makerVM);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            CarMaker maker;
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                maker = dbContext.CarMaker.Find(id);
            }
            return View(maker);
        }

        [HttpPost]
        public ActionResult Edit(CarMaker makerVM)
        {
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                dbContext.Entry(makerVM).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                CarMaker carmakerVM = dbContext.CarMaker.Find(id);
                dbContext.CarMaker.Remove(carmakerVM);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}