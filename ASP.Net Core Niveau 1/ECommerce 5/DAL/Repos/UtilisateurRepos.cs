using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class UtilisateurRepos
    {
        public List<Utilisateur> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Utilisateurs.ToList();
        }
    }
}
