using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PanierRepos
    {
        public int Create(Panier entity)
        { 
            MyDbContext db = new MyDbContext();
            db.Paniers.Add(entity);
            return db.SaveChanges();
        }
        public List<Panier> All (Panier entity) 
        { 
            MyDbContext db = new MyDbContext();
            return db.Paniers.ToList();
        }

        public Panier Read(int id)
        {
            MyDbContext db = new MyDbContext();
            return db.Paniers.Find(id);
        }

    }
}
