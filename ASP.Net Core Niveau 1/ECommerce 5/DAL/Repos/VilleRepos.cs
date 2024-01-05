
using DAL.Entity;
using DAL.Migrations;

namespace DAL.Repos;

public class VilleRepos
{
    public void Create(Ville entity)
    {
        MyDbContext myDbContext = new MyDbContext();
        myDbContext.Villes.Add(entity); 
        myDbContext.SaveChanges();
    }

    public List<Ville> All()
    {
        MyDbContext myDbContext = new MyDbContext();

        return myDbContext.Villes.ToList();
    }

}
