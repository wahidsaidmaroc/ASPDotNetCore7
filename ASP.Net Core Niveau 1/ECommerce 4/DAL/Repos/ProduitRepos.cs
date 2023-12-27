

using DAL.Entity;

namespace DAL.Repos;

public class ProduitRepos
{
    public void Create(Produit entity)
    {
        MyDbContext mydb = new MyDbContext();
        mydb.Produits.Add(entity);
        mydb.SaveChanges();
    }

    public Produit Read(int id)
    {
        MyDbContext mydb = new MyDbContext();
        return mydb.Produits.Find(id);
    }

    public List<Produit> ReadAll() 
    {
        MyDbContext mydb = new MyDbContext();
        return mydb.Produits.ToList();
    }
}
