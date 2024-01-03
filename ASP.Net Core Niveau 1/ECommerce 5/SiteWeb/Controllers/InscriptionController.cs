using Microsoft.AspNetCore.Mvc;
using Models.Inscription;

namespace SiteWeb.Controllers
{
    public class InscriptionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(InscriptionVM model )
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatioCompte()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatioCompte(InscriptionVM model)
        {
            return View();
        }


    }
}
