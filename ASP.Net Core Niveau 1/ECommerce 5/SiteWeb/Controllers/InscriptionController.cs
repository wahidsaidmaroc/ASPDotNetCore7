using DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using Models.Inscription;
using BLL;

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
        public IActionResult CreationCompte()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreationCompte(InscriptionVM model)
        {
            ClientService service = new ClientService();
            service.CreationCompte(model);
            return View();
        }


    }
}
