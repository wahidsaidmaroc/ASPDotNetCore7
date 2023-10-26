using Microsoft.AspNetCore.Mvc;

namespace SiteWeb.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
