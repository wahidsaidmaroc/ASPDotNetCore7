using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CarousselRepos
    {
        public void Create(Caroussel entity)
        {
            MyDbContext db = new MyDbContext();
            db.Caroussels.Add(entity);
            db.SaveChanges();
        }

        public Caroussel Read(int id) 
        {
            MyDbContext db = new MyDbContext();
            var entity = db.Caroussels.Find(id);
            return entity;
        }

        public List<Caroussel> All() 
        {
            MyDbContext db = new MyDbContext();
            return db.Caroussels.ToList();
        }
    }
}
