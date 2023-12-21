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
            var list = new List<CategorieListViewModel>();

            for (int i = 1; i <=4; i++)
            {
                var m = new CategorieListViewModel { Id = i, Nom = $"Catégorie {i}", Description = $"Description de la Catégorie {i}" };
                list.Add(m);
            }

            ViewData["TitrePage"] = "Nos Produits par Catégorie";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";
            
            return View(list);
        }

        /// <summary>
        ///  Adresse Serveur/Produit/Liste
        /// </summary>
        /// <returns></returns>
        public IActionResult Liste(int id)
        {
            Random rd= new Random();
            var list = new List<ProduitListVM>();

            for (int i = 1; i <= 10; i++)
            {
                
                var m = new ProduitListVM { Id = i, Nom = $"Produit {i}", Description = $"Description du produit {i}",Prix= rd.Next(10,200)};
                list.Add(m);
            }

            ViewData["TitrePage"] = $"Le produit de la categorie {id}";
            ViewData["DescriptioPage"] = "Description de la page Catégorie";

            return View(list);
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
