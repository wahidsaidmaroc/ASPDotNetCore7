using Microsoft.AspNetCore.Mvc;

namespace SiteWeb.Controllers
{
    public class ProduitController : Controller
    {
        /// <summary>
        ///  Adresse Serveur/Produit/Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {

            return View();
        }
    }
}
