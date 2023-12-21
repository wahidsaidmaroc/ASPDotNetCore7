using BLL.NosService;
using Microsoft.AspNetCore.Mvc;
using Models.Service;

namespace SiteWeb.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            NosService nosService = new NosService();
            return View(nosService.ToList());
        }

        public IActionResult Details(int id)
        {
         
            ViewData["Titre"] = "Mes Service " ;
            NosService nosService = new NosService();

            return View(nosService.ToDetail());
        }
    }
}
