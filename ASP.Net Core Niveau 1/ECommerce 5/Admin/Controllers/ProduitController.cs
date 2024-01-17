using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Produit;

namespace Admin.Controllers
{
    [Authorize]

    public class ProduitController : Controller
    {
        // GET: ProduitController
        public ActionResult Index()
        {
            ProduitService service = new ProduitService();

            return View(service.ListProduit());
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            CategorieService categorieService = new CategorieService();
            MarqueService marqueService = new MarqueService();

   
            ViewData["Title"] = "Création Produit";

            ViewBag.ListCate = categorieService.AdminListVM();
            ViewBag.ListMarque = marqueService.GetListMarques();

            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdminProduitAjouterVM model)
        {

            if (ModelState.IsValid)
            {

                try
                {
                    ProduitService service = new ProduitService();
                    service.Create(model);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }


            }
            return RedirectToAction(nameof(Create));

        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
