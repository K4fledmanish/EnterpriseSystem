using ControllerLayer;
using MediaLibrary.Models;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static ControllerLayer.DTOCollection;

namespace MediaLibrary.Controllers
{
    public class MediaController : Controller
    {

        IMediaManager mediaManager = new MediaManagerImpl();
        IUserManager userManager = new UserManagerImpl();
        // GET: Media
        public ActionResult MediaDisplay()
        {
            if (Session["UserLevel"] != null)
            {
                ViewBag.media = mediaManager.ViewMedia();
                return View();
            }
            return View("~/Views/User/LoginUser.cshtml");
        }


        public ActionResult ViewDirectors()
        {
            ViewBag.directors = mediaManager.getDirectors();
            return View();
        }

        public ActionResult ViewLanguage()
        {
            ViewBag.language = mediaManager.getLanguage();
            return View();
        }

        public ActionResult ViewGenre()
        {
            ViewBag.genre = mediaManager.getGenre();
            return View();
        }

        public ActionResult InsertMedia(Media medias)
        {
            if ((int)Session["UserLevel"] == 3)
            {
                IMediaManager mediaManager = new MediaManagerImpl();

                int value = mediaManager.InsertMedia(medias.Title, medias.Genere, medias.Director, medias.Language, medias.PublishYear, medias.Budget);

                var viewDirectors = mediaManager.getDirectors();
                var viewGenre = mediaManager.getGenre();
                var viewLanguage = mediaManager.getLanguage();

                ViewBag.Director = viewDirectors;
                ViewBag.Genre = viewGenre;
                ViewBag.Language = viewLanguage;

                if (value > 0)
                {
                    MediaDisplay();
                    return View("MediaDisplay");
                }
            }
            return View();
        }

        public ActionResult DeleteMedia(Media model)
        {
            if ((int)Session["UserLevel"] == 3)
            {
                mediaManager.DeleteMedia(model.MediaID);
            }
            MediaDisplay();
            return View("MediaDisplay");
        }

        public ActionResult BrowseAll(Media booksModel)
        {
            var column = booksModel.selection;
            var value = booksModel.input;
            var listOfBooks = mediaManager.viewMediaByValue(value, column);
            ViewBag.media = listOfBooks;
            return View("MediaDisplay");
        }

        public ActionResult InputBorrow(UserValue userValue, Media media)
        {
            DateTime dateTime = DateTime.Now;
            string todayStr = dateTime.ToString();
            DateTime returnDate = dateTime.AddDays(10);
            string returnDateStr = returnDate.ToString();
            userManager.InsertBorrow(userValue.UID, media.MediaID, todayStr,returnDateStr);
            ViewBag.msg = "Borrowed";
            MediaDisplay();
            return View("MediaDisplay");
        }

        public ActionResult InsertReserve(UserValue userValue, Media media)
        {
            string date = DateTime.Now.ToString();
            userManager.InsertReserve(userValue.UID, media.MediaID, date);
            ViewBag.msg = "Media is Reserved. Enjoy!!!!";
            MediaDisplay();
            return View("MediaDisplay");
        }

        public ActionResult ReserveGet()
        {

            var reserveList = userManager.GetReserves();
            ViewBag.reserveList = reserveList;
            return View();
        }

        public ActionResult ShowBorrow()
        {
            var borrowList = userManager.GetBorrows((int)'1');
            ViewBag.borrowList = borrowList;
            return View();
        }

        public ActionResult InsertReturn(Models.Borrow borrowModel)
        {
            DateTime today = DateTime.Now;
            string todayStr = today.ToString();
            string returnDateStr = borrowModel.ReturnDate;
            DateTime returnDate = DateTime.Parse(returnDateStr);
            double diff = (today - returnDate).TotalDays;
            int difference = (int)diff;
            if (difference < 0)
            {
                difference = 0;
            }
            decimal lateFee = difference * 10;
            userManager.InsertReturn(todayStr, lateFee, borrowModel.BID, borrowModel.MediaID);

            ShowBorrow();
            return View("ShowBorrow");
        }

        public ActionResult UpdateMedia(Media media)
        {
            if ((int)Session["UserLevel"] == 3)
            {
                int row = mediaManager.UpdateMedia(media.Title, media.Genere, media.Director, media.Language, media.PublishYear, media.Budget, media.MediaID);
                IMediaManager mediaManagerImpl = new MediaManagerImpl();
                var allDirectors = mediaManagerImpl.getDirectors();
                var allGenre = mediaManagerImpl.getGenre();
                var allLang = mediaManagerImpl.getLanguage();

                ViewBag.Directors = allDirectors;
                ViewBag.Genre = allGenre;
                ViewBag.Languages = allLang;


                if (row > 0)
                {
                    MediaDisplay();
                    return View("MediaDisplay");
                }
            }
            return View();
        }

        public ActionResult InsertDirector(Directors dirDTO)
        {
            int row = mediaManager.InsertDirector(dirDTO.DirectorName);
            ViewDirectors();
            return View("ViewDirectors");
        }

        public ActionResult InsertLanguage(Language languageDTO)
        {
            int row = mediaManager.InsertLanguage(languageDTO.LanguageName);
            ViewLanguage();
            return View("ViewLanguage");
        }

        public ActionResult InsertGenre(Genre genreDTO)
        {
            int row = mediaManager.InsertGenre(genreDTO.GenreName);
            ViewGenre();
            return View("ViewGenre");
        }

        public ActionResult DeleteGenre(Genre genreDTO)
        {
            mediaManager.DeleteGenre(genreDTO.GID);
            ViewGenre();
            return View("ViewGenre");

        }
            public ActionResult DeleteDirector(Directors directorDTO)
            {
                mediaManager.DeleteDirector(directorDTO.DID);
            ViewDirectors();
                return View("ViewDirectors");
            }

            public ActionResult DeleteLanguage(Language languageDTO)
            {
                mediaManager.DeleteGenre(languageDTO.LID);
            ViewLanguage();
                return View("ViewLanguage");
            }

        public ActionResult UpdateGenre(Genre genDTO)
        {
            int row = mediaManager.UpdateGenre(genDTO.GenreName, genDTO.GID);
            ViewGenre();
            return View("ViewGenre");
        }

        public ActionResult UpdateLanguage(Language languageDTO)
        {
            int row = mediaManager.UpdateLanguage(languageDTO.LanguageName, languageDTO.LID);
            ViewLanguage();
            return View("ViewLanguage");
        }

        public ActionResult UpdateDirector(Directors directorDTO)
        {
            int row = mediaManager.UpdateDirector(directorDTO.DirectorName, directorDTO.DID);
            ViewDirectors();
            return View("ViewDirector");
        }
    }
}