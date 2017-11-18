using MVCTutorials9AM.Models;
using MVCTutorials9AM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM.Controllers
{
    public class StudentController : Controller
    {
        StudentService studentServiceObj;
        public StudentController()
        {
            studentServiceObj = new StudentService();
        }
        public ActionResult Index(int id=0)
        {            
            return View(studentServiceObj.GetAll());
        }

        public ActionResult Details(int id)
        {
            var data = studentServiceObj.GetStudentById(id);
            return View(data);
        }

        public ActionResult Delete(int id)
        {
            return RedirectToAction("Index", new { id = id });
        }


        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult CreateNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNew(StudentVM studentVMData)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(studentVMData);
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
