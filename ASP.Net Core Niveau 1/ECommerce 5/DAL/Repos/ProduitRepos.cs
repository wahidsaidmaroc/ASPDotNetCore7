

using DAL.Entity;
using Microsoft.EntityFrameworkCore;

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

    public void Update(Produit entity)
    {
        MyDbContext mydb = new MyDbContext();
        mydb.Entry(entity).State = EntityState.Modified;
        mydb.SaveChanges();
    }

    public void Delete(int id)
    {
        MyDbContext mydb = new MyDbContext();
        Produit entity = mydb.Produits.Find(id);
        mydb.Produits.Remove(entity);
        mydb.SaveChanges();
    }
}
