using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
