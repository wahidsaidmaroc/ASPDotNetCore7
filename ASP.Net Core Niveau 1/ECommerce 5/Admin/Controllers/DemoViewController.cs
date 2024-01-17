using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class DemoViewController : Controller
    {
        [Authorize]
        public IActionResult DemoViewBag()
        {
     
            ViewBag.Var1 = "1";
            ViewBag.Var2 =  "Said V2";
            ViewBag.Var3 = 12;
            return View();
        }
        [AllowAnonymous]
        public IActionResult DemoViewData()
        {
            ViewData["ListCat"] = DateTime.Now;
                  return View();
        }
        public IActionResult DemoViewTemps()
        {
            TempData["name"] = "Said";

            return View();
        }
        public IActionResult DemoViewTempsTest()
        {
            var a=  TempData["name"].ToString();
            return View();
        }
    }
}
