using Microsoft.AspNetCore.Mvc;

namespace SiteWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
