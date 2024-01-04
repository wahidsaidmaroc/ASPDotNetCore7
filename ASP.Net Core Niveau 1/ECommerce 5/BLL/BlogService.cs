using DAL.Entity;
using DAL.Repos;
using Models.Blog;
using Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BlogService
    {

        public List<BlogListVM> ToList()
        {
            var blogRepos = new BlogRepos();
            var list = new List<BlogListVM>();


            foreach (var item in blogRepos.GetAll())
            {
                BlogListVM blogListVM = new BlogListVM
                {
                    Categorie = item.Categorie,
                    Description = item.Description,
                    Titre = item.Titre,
                    Date = item.DateCreation,
                    Id = item.CodeTable
                };

                list.Add(blogListVM);
            }

            return list;
        }

        public BlogDetailVM GetDetail(int idBlog)
        {
            BlogRepos   blogRepos = new BlogRepos();
            var objet = blogRepos.Read(idBlog);

            BlogDetailVM blogDetailVM = new BlogDetailVM
            {
                Categorie = objet.Categorie,
                Description = objet.Description,
                Date = objet.DateCreation,
                Titre = objet.Titre            };

            return blogDetailVM;
        }


        public void AjouterBlog(AdminBlogCreateMV model)
        {
            var blogRepos = new BlogRepos();
            Blog blog = new Blog
            {
                Categorie = model.Categorie,
                DateCreation = DateTime.Now,
                Description = model.Description,
                Titre = model.Titre
            };
            blogRepos.Create(blog);
        }


    }
}
