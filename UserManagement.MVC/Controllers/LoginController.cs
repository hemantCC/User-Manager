using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagement.EntityLayer.DataEntity;
using UserManagement.BusinessLayer;

namespace UserManagement.MVC.Controllers
{
    public class LoginController : Controller
    {
        private LoginBL loginBL = new LoginBL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(tblLogin LoginUser)
        {
            bool isValid =  loginBL.ValidateUser(LoginUser);
            if (isValid) 
            {
                Session["user"] = LoginUser.Username;
                return RedirectToAction("Index","User");
            }
            else
            {
                ModelState.AddModelError("", "Invalid User Name or Password");
               
            }
            return View(LoginUser);
        }

        public ActionResult Logout()
        {
            Session.Remove("user");
            return RedirectToAction("Index","Login");
        }
    }
}