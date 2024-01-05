using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class MarqueRepos
    {
        public List<Marque> All()
        {
            MyDbContext db = new MyDbContext();
            return db.Marques.ToList();
        }
        public void Create(Marque entity)
        {
            MyDbContext db = new MyDbContext();
            db.Marques.Add(entity);
            db.SaveChanges();
        }
    }
}
