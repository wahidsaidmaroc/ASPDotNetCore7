using DAL.Repos;
using Models.Pays;

namespace BLL
{
    public class PaysService
    {
        public List<Models.Pays.PaysListvm> List()
        {
            List<Models.Pays.PaysListvm> listvms = new List<Models.Pays.PaysListvm>();
            PaysRepos paysRepos = new PaysRepos();

            foreach (var item in paysRepos.All())
            {
                PaysListvm paysListvm = new PaysListvm { Code = item.Code, Nom = item.Nom };
                listvms.Add(paysListvm);
            }

            
            return listvms;
        }

    }
}
