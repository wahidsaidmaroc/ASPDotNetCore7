using Microsoft.AspNetCore.Mvc;
using Models.Auth;

namespace Admin.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserAuthVM model)
        {
            return View();
        }
    }
}
