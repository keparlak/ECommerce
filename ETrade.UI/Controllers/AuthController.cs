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
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", u);
            return RedirectToAction("Index", "Home");
        }
    }
}