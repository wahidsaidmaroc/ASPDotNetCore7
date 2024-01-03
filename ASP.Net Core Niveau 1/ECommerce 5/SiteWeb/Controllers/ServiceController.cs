using BLL;
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
            if (id == 0 || id == null)
            {
                return NotFound();
            }
         
            ViewData["Titre"] = "Mes Service " ;
            NosService nosService = new NosService();

            return View(nosService.ToDetail(id));
        }
    }
}
