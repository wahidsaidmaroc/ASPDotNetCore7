using DAL.Entity;

namespace DAL.Repos;

public class CommandeRepos
{

    public int Create(Commande entity)
    {
        MyDbContext myDbContext = new MyDbContext();
        myDbContext.Commandes.Add(entity);  
        return myDbContext.SaveChanges();
    }
    public Commande Read(int id)
    {
        MyDbContext myDbContext = new MyDbContext();
        return myDbContext.Commandes.Find(id);

    }
    public List<Commande> All() {
        MyDbContext myDbContext = new MyDbContext();
        return myDbContext.Commandes.ToList(); 

    }

}
