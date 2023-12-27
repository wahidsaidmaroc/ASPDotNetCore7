using Microsoft.AspNetCore.Mvc;
using Models.Blog;

namespace SiteWeb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<BlogListVM> list = new List<BlogListVM>();

            for (int i = 0; i < 10; i++)
            {
                BlogListVM vm = new BlogListVM();
                vm.Description = $"Description blog {i}";
                vm.Titre = $"Titre blog{i}";
                vm.Date = DateTime.Now;
                vm.Categorie = "Cat A";
                list.Add(vm);
            }


            return View(list);
        }
        public IActionResult Detail() {

            BlogDetailVM blogDetailVM = new BlogDetailVM();
            blogDetailVM.Titre = "titre 1";
            blogDetailVM.Date = DateTime.Now;
            blogDetailVM.Description = "Anazwin";
            blogDetailVM.Categorie = "Categorie";

            


           return View(blogDetailVM); }

    }
}
