using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PanierProduitRepos
    {
        public void Create(PanierProduit entity)
        {
            MyDbContext db = new MyDbContext();
            db.PanierProduits.Add(entity);
            db.SaveChanges();
        }
        public List<PanierProduit> All(PanierProduit entity)
        {
            MyDbContext db = new MyDbContext();
            return db.PanierProduits.ToList();
        }
    }
}
