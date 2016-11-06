using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TranscriptsDNURT.Domain.Interfaces;
using TranscriptDNURT.WebUI.Models;

namespace Transcript.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository repository;

        public AccountController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                TranscriptsDNURT.Domain.Entities.User user = repository.Users.Where(_ => _.Login == loginModel.login && _.Password == loginModel.password).FirstOrDefault();
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(loginModel.login, true);

                    TempData["message"] = null;

                    return RedirectToAction("AdminPanel", "Account");
                }
                else
                {
                    TempData["message"] = "Пользователя с таким логином и паролем нет";

                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginModel);
        }

        public ActionResult AdminPanel()
        {
            return View();
        }
    }
}