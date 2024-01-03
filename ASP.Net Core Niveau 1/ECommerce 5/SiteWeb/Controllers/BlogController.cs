using BLL;
using Microsoft.AspNetCore.Mvc;
using Models.Blog;

namespace SiteWeb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {

            BlogService blogService = new BlogService();
            return View(blogService.ToList());
        }
        public IActionResult Detail(int id)
        {

            if (id == 0 || id == null)
            {
                return NotFound();
            }


            BlogService blogService = new BlogService();

            return View(blogService.GetDetail(id)); }

    }
}
