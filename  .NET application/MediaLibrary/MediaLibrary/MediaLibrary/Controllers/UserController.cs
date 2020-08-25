using ControllerLayer;
using MediaLibrary.Models;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Collections.Specialized.BitVector32;

namespace MediaLibrary.Controllers
{
    public class UserController : Controller
    {
        IUserManager userManager = new UserManagerImpl();
        // GET: User
        public ActionResult ShowUsers()
        {

            var users = userManager.getUsers();
            ViewBag.userManager = users;

            return View();
        }


        public ActionResult LoginUser()
        {
            return View();
        }

        public ActionResult UserVerify(UserValue userAccount)
        {
            IUserManager userManager = new UserManagerImpl();

            bool validUser = userManager.userVerify(userAccount.userName, userAccount.password);

            if (validUser )
            {
                Session["UserName"] = userAccount.userName;
                Session["UID"] = userAccount.UID;
                Session["UserLevel"] = userAccount.userLevel;
                ViewBag.user = userAccount.userName;

                return View("~/Views/Media/MediaDisplay.cshtml");

            }

            else
            {
                ViewBag.user = null;
                return View("LoginUser");
            }
        }
        public ActionResult InsertUser(UserValue userAccount)
        {
            if (userAccount.userName != null && userAccount.password != null)
            {
                userManager.InsertUser(userAccount.userName, userAccount.userEmail, userAccount.userLevel, userAccount.password);
                ShowUsers();
                return View("ShowUsers");
            }
            ViewBag.ValidateMsg = "Please Try Again !";
           
                return View();
            
        }

        public ActionResult DeleteUser(UserValue userAccount)
        {
            userManager.DeleteUser(userAccount.UID);
            ShowUsers();
            return View("ShowUsers");
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return View("~/Views/Home/Index.cshtml");
        }


        public ActionResult UpdateUser(UserValue userModel)
        {
            if (userModel.userName != null)
            {
                userManager.UpdateUser(userModel.UID, userModel.userName, userModel.userEmail, userModel.userLevel, userModel.password);
                ShowUsers();
                return View("ShowUsers");
            }
            return View();

        }


    }
}