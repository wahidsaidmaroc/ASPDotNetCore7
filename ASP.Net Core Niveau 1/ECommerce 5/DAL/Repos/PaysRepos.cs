using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PaysRepos
    {
        public void Create(Pays entity)
        {
            MyDbContext myDbContext = new MyDbContext();
            myDbContext.Payss.Add(entity);
            myDbContext.SaveChanges();
        }

        public List<Pays> All()
        {
            MyDbContext myDbContext = new MyDbContext();

            return myDbContext.Payss.ToList();
        }

    }
}
