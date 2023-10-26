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

        /// <summary>
        ///  Adresse Serveur/Produit/Liste
        /// </summary>
        /// <returns></returns>
        public IActionResult Liste()
        {
            return View();
        }
        /// <summary>
        ///  Adresse Serveur/Produit/Detail
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail()
        {
            return View();
        }
    }
}
