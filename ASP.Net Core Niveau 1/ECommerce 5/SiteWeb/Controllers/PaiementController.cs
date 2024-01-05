using Microsoft.AspNetCore.Mvc;
using Models.Paiement;

namespace SiteWeb.Controllers
{
    public class PaiementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]        
        public IActionResult Index(PaiementVm model)
        {

            return View();
        }

    }
}
