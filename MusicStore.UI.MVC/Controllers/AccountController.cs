using MusicStore.BLL.Abstract;
using MusicStore.Model;
using MusicStore.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;

        public AccountController(IUserService user)
        {
            _userService = user;
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                _userService.Insert(user);
                bool sonuc = MailHelper.SendConfirmationMail(user.UserName, user.Password, user.Mail, user.ID);
                if (!sonuc)
                {
                    ViewBag.Error = "Mail can't sent";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.Error = "Successfully signed up.";
                return View();
            }
            return RedirectToAction("Login", "Account");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var gelenKullanici = _userService.GetUserByLogin(user.UserName, user.Password);
            if (gelenKullanici != null)
            {
                Session["kullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Kullanıcı bulunamadı";
            return View();
        }
    }
}