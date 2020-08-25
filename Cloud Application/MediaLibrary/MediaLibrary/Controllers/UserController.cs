
using MediaLibrary.Models;
using MediaLibraryWFC;
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
        UserManagement userManager = new UserManagerImpl();

        MediaController md = new MediaController();
        // GET: User

        public ActionResult Index()
        {

            return View();
        }


        public ActionResult ShowUsers()
        {

            var users = userManager.getUsers();
            ViewBag.userManager = users;

            return View();
        }


        public ActionResult LoginUser()
        {
            MediaManagement mediaManager = new MediaManagerImpl();
            ViewBag.media = mediaManager.ViewMedia();
            return View();
        }

        public ActionResult UserVerify(UserValue userAccount)
        {
            UserManagement userManager = new UserManagerImpl();


            if (userAccount.userName != null && userAccount.password != null)
            {
                var userValid = userManager.userVerify(userAccount.userName, userAccount.password);


                if (userValid != null)
                {
                    foreach (var eachField in userValid)
                    {
                        userAccount.UID = eachField.UID;
                        userAccount.userLevel = eachField.userLevel;
                    }
                    Session["UserName"] = userAccount.userName;
                    Session["UID"] = userAccount.UID;
                    Session["UserLevel"] = userAccount.userLevel;
                    
                    return View("~/Views/Home/Index.cshtml");
                }

                else
                {
                   
                    ViewBag.ValidateMsg = "Please fill required fields.";
                    return View("LoginUser");
                }
            }
            return View("LoginUser");

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
            return View("~/Views/Home/About.cshtml");
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