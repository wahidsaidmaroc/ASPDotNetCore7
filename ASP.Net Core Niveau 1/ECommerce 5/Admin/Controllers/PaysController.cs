using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    [Authorize]
    public class PaysController : Controller
    {
        // GET: PaysController
        public ActionResult Index()
        {
            PaysService paysService = new PaysService();
            return View(paysService.List());
        }

        // GET: PaysController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaysController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaysController/Create
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

        // GET: PaysController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaysController/Edit/5
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

        // GET: PaysController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaysController/Delete/5
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
