using Microsoft.AspNetCore.Mvc;
using Models.Panier;

namespace SiteWeb.Controllers
{
    public class PanierController : Controller
    {
        public IActionResult Index(int id )
        {   PanierVM panierVM = new PanierVM();
            panierVM.Date = DateTime.Now;
            panierVM.Total = 0;
            for (int i = 0; i < 5; i++)
            {
                LignPanier P = new LignPanier();
                P.IdProduit = id;
                P.Quantite = 1+i;
                P.PrixProduit = 9 * i;
                P.Description = "Description " + i;
                panierVM.L.Add(P);
            }

            ViewData["NomPanier"] = "Mon Panier";
            ViewData["Title"] = "Mon Panier";
            return View(panierVM);
        }
    }
}
