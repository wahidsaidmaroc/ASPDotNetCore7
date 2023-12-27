

using DAL.Entity;

namespace DAL.Repos;

public class ProduitRepos
{
    void Add(Produit obj)
    {
        MyDbContext mydb = new MyDbContext();
        mydb.Produits.Add(obj);
        mydb.SaveChanges();
    }

}
