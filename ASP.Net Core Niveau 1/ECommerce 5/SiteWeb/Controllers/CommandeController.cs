using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Commande;

namespace SiteWeb.Controllers
{
    public class CommandeController : Controller
    {
        public IActionResult Index()
        {
            CommandeVM vm = new CommandeVM { Numero = 1, Total = 200, Date = DateTime.Now};
            vm.LigneCommandes.Add(new LigneCommandeVM { Code = 22, Description = "jaaf", Quantite = 2 ,PU=10});
            vm.LigneCommandes.Add(new LigneCommandeVM { Code = 23, Description = "jaafa", Quantite = 21, PU = 65 });
            vm.LigneCommandes.Add(new LigneCommandeVM { Code = 24, Description = "jaafar", Quantite = 1, PU = 66 });

            ViewData["TitrePage"] = "Ma commande";
            return View(vm);
        }
        public IActionResult Recapitulatif()
        {
            ViewData["TitrePage"] = "Recapitulatif Ma Commande";

            CommandeRecapVM model = new CommandeRecapVM();
            model.Nom = "WAHID";
            model.Prenom = "Said";
            model.Lp.Add(new LigneCommandeRecapVM { Nom = "Produit A", Prix = 123, Qte = 12 });
            model.Lp.Add(new LigneCommandeRecapVM { Nom = "Produit A", Prix = 123, Qte = 12 });
            return View(model);
        }
        public IActionResult FinCommande()
        {
            CommandeFinVM model = new CommandeFinVM { Nom = "Amine", Prenom = "Ali", Adresse = "Hay moulay rachid 1", NumCommande = 122, Montant = 200.42, };
    
            for (int i = 0; i < 3; i++)
            {
                CommandeLigneFinVM ListeVM = new CommandeLigneFinVM
                {
                    NomProduit= $"MP{i}",
                    Prix=200.42 * i
                };
                model.Ligne.Add(ListeVM);
                model.Montant += ListeVM.Prix;
            }

            ViewData["Titre"] = "Commande Informations";

            return View(model);

        }
    }
    
}
