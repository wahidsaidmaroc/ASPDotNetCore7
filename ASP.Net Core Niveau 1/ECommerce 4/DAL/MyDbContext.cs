
using DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MyDbContext : DbContext
    {

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Caroussel> Caroussels { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Data Source=Localhost\SQLEXPRESS;Initial Catalog=StoreDBLearn;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
    }
}
