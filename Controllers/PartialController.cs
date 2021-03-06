﻿using MVCTutorials9AM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials9AM.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
        public ActionResult Index()
        {
            List<StudentVM> studentListobj = new List<StudentVM>();
            studentListobj.Add(new StudentVM { ID = 101, Name = "student1" });
            studentListobj.Add(new StudentVM { ID = 102, Name = "student2" });

            //ViewBag.Students = studentList;
            return View(studentListobj);
        }

        public ViewResult MultiModel()
        {
            List<StudentVM> studentListobj = new List<StudentVM>();
            studentListobj.Add(new StudentVM { ID = 101, Name = "student1" });
            studentListobj.Add(new StudentVM { ID = 102, Name = "student2" });

            DepartmentVM deptObj = new DepartmentVM();
            deptObj.Name = "Computer";

            StudentDeptVM stdDepatObj = new StudentDeptVM();
            stdDepatObj.StudentList = studentListobj;
            stdDepatObj.Department = deptObj;

            //ViewBag.Students = studentList;
            return View(stdDepatObj);
        }

        
        public PartialViewResult Partial2()
        {
            return PartialView();
        }

        public ActionResult contentData()
        {
            return Content("This is sample content");
        }
        public ActionResult JsonData()
        {
            var data = new StudentVM { ID = 100, Name = "Rama", Email = "rama@gmail.com" };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult File()
        {
            string filename = "~/Content/flower.jpg";
            return File(filename, MimeMapping.GetMimeMapping(filename));
        }
    }
}