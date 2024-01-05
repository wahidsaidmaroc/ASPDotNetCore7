using BLL;
using Microsoft.AspNetCore.Mvc;
using Models.Panier;
using NuGet.Protocol.Core.Types;

namespace SiteWeb.Controllers
{
    public class PanierController : Controller
    {
        public IActionResult Index(int id, IFormCollection data )
        {
            var qnt = data["nbrArticle"];
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            //Ajouter Produit dnas le panier
            PanierService panierService = new PanierService();
            panierService.CreatePanier( id );


         
            ViewData["NomPanier"] = "Mon Panier";
            ViewData["Title"] = "Mon Panier";
            return View(panierService.GetPanier());
        }
    }
}
