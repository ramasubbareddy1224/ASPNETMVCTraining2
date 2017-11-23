using MVCTutorials9AM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCTutorials9AM.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Customer customerVM)
        {
            using (CMSDBContext dbContext = new CMSDBContext())
            {
                int userCount = dbContext.Customer.Count(i => i.Email == customerVM.Email && i.Password == customerVM.Password && i.RoleID == 2);
                if (userCount > 0)
                {
                    FormsAuthentication.SetAuthCookie(customerVM.Email, false);
                    return RedirectToAction("Index", "CarHome");
                }
                else
                {
                    ViewBag.Error = "Invalid Email or Password";
                    return View();
                }
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Login","Account");
        }
    }
}