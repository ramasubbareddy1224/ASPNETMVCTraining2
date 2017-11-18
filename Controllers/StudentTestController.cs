using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTutorials9AM.Models;

namespace MVCTutorials9AM.Controllers
{
    public class StudentTestController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentTest
        public ActionResult Index()
        {
            return View(db.StudentVMs.ToList());
        }

        // GET: StudentTest/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentVM studentVM = db.StudentVMs.Find(id);
            if (studentVM == null)
            {
                return HttpNotFound();
            }
            return View(studentVM);
        }

        // GET: StudentTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentTest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,Phone,Address")] StudentVM studentVM)
        {
            if (ModelState.IsValid)
            {
                db.StudentVMs.Add(studentVM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentVM);
        }

        // GET: StudentTest/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentVM studentVM = db.StudentVMs.Find(id);
            if (studentVM == null)
            {
                return HttpNotFound();
            }
            return View(studentVM);
        }

        // POST: StudentTest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Email,Phone,Address")] StudentVM studentVM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentVM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentVM);
        }

        // GET: StudentTest/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentVM studentVM = db.StudentVMs.Find(id);
            if (studentVM == null)
            {
                return HttpNotFound();
            }
            return View(studentVM);
        }

        // POST: StudentTest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentVM studentVM = db.StudentVMs.Find(id);
            db.StudentVMs.Remove(studentVM);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
