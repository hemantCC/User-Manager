using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UserManagement.BusinessLayer;
using UserManagement.EntityLayer.DataEntity;
using UserManagement.MVC.Filters;

namespace UserManagement.MVC.Controllers
{
    [IfAuthorised]
    public class UserController : Controller
    {
        private UserBL userBL = new UserBL();
        
        // GET: User
        [HttpGet]
        public ActionResult Index()
        {
            return View(userBL.GetAllUsers());
        }

        [HttpGet]
        public ActionResult AddOrEditUser(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            { 
                return View(userBL.GetUser(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrEditUser(tblUserDetail userDetail)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    if (userDetail.Id == 0)
                    {
                        userBL.AddUser(userDetail);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        userBL.EditUser(userDetail);
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch(Exception)
            {
                return View("Error");
            }
            
        }


        [HttpGet]
        public ActionResult DeleteUser(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(userBL.GetUser(id));
        }

        [HttpPost]
        public ActionResult ConfirmDelete(int id)
        {
            try
            {
                userBL.DeleteUser(id);
                return RedirectToAction("index");
            }
            catch (Exception)
            { 
                return View("Error");
            }

        }


    }
}