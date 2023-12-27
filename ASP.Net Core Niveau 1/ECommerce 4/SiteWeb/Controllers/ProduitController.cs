using BLL;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Models.Produit;

namespace SiteWeb.Controllers
{
    public class ProduitController : Controller
    {
        /// <summary>
        ///  localhost/Produit/Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            CategorieService categorieService = new CategorieService();

            ViewData["TitrePage"] = "Nos Produits par Catégorie";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";
            
            return View(categorieService.ListDetailVM());
        }

        /// <summary>
        ///  Adresse Serveur/Produit/Liste
        /// </summary>
        /// <returns></returns>
        public IActionResult Liste(int id)
        {

            if (id == 0 )
            {
                return NotFound();
            }
            ProduitService produitService = new ProduitService();


             ViewData["TitrePage"] = $"Le produit de la categorie {id}";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";

            return View(produitService.ListParCategorie(id));
        }
        
        /// <summary>
        ///  Adresse Serveur/Produit/Detail
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail()
        {
           
            ProduitDetailVM vm = new ProduitDetailVM();
            vm.Id = 1;
            vm.Prix = 300;
            vm.Titre = "Casque";
            vm.Description = "P9 Casque Bluetooth P9 Sans Fil, Ecouteur Bluetooth 5.0";

            ViewData["Title"] = vm.Titre;
            ViewData["Description"] = vm.Description;
            return View(vm);
        }
    }
}
