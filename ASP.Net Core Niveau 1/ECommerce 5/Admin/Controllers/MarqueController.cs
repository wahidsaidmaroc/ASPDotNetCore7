using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Marque;

namespace Admin.Controllers
{
    public class MarqueController : Controller
    {
        // GET: MarqueController
        public ActionResult Index()
        {
            List<ListMarqueVM> list = new List<ListMarqueVM>();
            return View(list);
                    
        }
        
        // GET: MarqueController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MarqueController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarqueController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: MarqueController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MarqueController/Edit/5
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

        // GET: MarqueController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MarqueController/Delete/5
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
