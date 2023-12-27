using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Profil;
using System.Runtime.InteropServices;

namespace SiteWeb.Controllers
{
    public class ProfilController : Controller
    {

        public IActionResult Index()
        {
            ProfilVM profilVM = new ProfilVM
            {
                Commandes = new List<ProfilCommandeVM> 
                { new ProfilCommandeVM { Description = "Description 1", Nom = "HP", Prix = 1209 } , 
                    new ProfilCommandeVM { Description = "Desciption 2", Nom = "MSI", Prix = 12009 } } ,
                Nom = "El ayoubi",
                Prenom = "Amine"
            };

            /*            profilVM.Commandes.Add(new ProfilCommandeVM { Description="Desciption 1", Nom="HP", Prix=1209});*/

            return View(profilVM);

        }
        public IActionResult MesCommandes()
        {
            var list = new  List<MesCommandesVM>();

            for (int i = 0; i < 10; i++)
            {
                MesCommandesVM obj = new MesCommandesVM
                { Date = DateTime.Now, Id = i, Montant = 120, Statut = "Livrée" };
                list.Add(obj);
            }



            return View(list);
        }
        public IActionResult MesPaiements() {
         return View();
        }
    }

}
