using Microsoft.AspNetCore.Mvc;

namespace SiteWeb.Controllers
{
    public class ContactController : Controller
    {
        public string Said()=> "KHALIfgdsgD";
        public IActionResult Index()
        {
            try
            {
                var id = 1;
                if (id == 1)
                {
                    return View();
                }
                return NotFound();
            }
            catch (Exception)
            {

                return RedirectToAction("Create");
            }
           
        }

        public IActionResult Create() => View();

    }
}
