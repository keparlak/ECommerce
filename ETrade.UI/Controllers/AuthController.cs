using ETrade.Ent;
using ETrade.UI.Session;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ETrade.UI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly Users user;

        public AuthController(IUow uow, Users user) : base(uow)
        {
            this.user = user;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Users u)
        {
            uow.UserRepository.Register(u);
            uow.Commit();
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult Login(Users u)
        {
            var loginUser = uow.UserRepository.Login(u);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", loginUser);
            SessionData.LoginUser = loginUser;
            if (SessionData.LoginUser.isAdmin == true)
            {
                return RedirectToAction("Admin", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Logout()
        {
            Users users = null;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", user);
            SessionData.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            return RedirectToAction("Index", "Home");
        }
    }
}