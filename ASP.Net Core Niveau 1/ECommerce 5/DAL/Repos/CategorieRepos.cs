using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    /// <summary>
    /// CRUD et ALL
    /// </summary>
    public class CategorieRepos
    {
        public List<Categorie> All()
        {
            MyDbContext db = new MyDbContext();
            return db.Categories.ToList();
        }
        public void Create(Categorie entity)
        {
            MyDbContext db = new MyDbContext();
            db.Categories.Add(entity);
            db.SaveChanges();
        }


    }
}
