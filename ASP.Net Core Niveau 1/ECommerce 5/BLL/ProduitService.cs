using DAL.Entity;
using DAL.Repos;
using Models.Produit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProduitService
    {

        public List<Models.Produit.ProduitListVM> ListParCategorie(int idCategorie)
        {
            var list = new List<Models.Produit.ProduitListVM>();

            //Phase 1 

            ProduitRepos repos = new ProduitRepos();
      

            foreach (var item in repos.ReadAll().Where(a => a.IdCategorie == idCategorie))
            {
                ProduitListVM obj = new ProduitListVM()
                { Description = item.Description, Id = item.Id , Nom = item.Titre , Prix = item.Prix };
                list.Add(obj);
            }

            return list;

        }

        public List<Models.Produit.AdminProduitListVM> ListProduit() 
        {
            var list = new List<Models.Produit.AdminProduitListVM>();
            ProduitRepos repos = new ProduitRepos();


            foreach (var item in repos.ReadAll())
            {
                AdminProduitListVM obj = new AdminProduitListVM()
                {  Id = item.Id, NomProduit = item.Titre, Prix = item.Prix };
                list.Add(obj);
            }

            return list;
        }
        


        public ProduitDetailVM Detail(int id)
        {
            var source = new ProduitRepos();
            var objSource  = source.Read(id);


            ProduitDetailVM obj = new ProduitDetailVM();

            obj.Id = objSource.Id;
            obj.Description = objSource.Description;
            obj.Prix = objSource.Prix;


            return obj;
        }

        public void Create(AdminProduitAjouterVM obj)
        {
            var source = new ProduitRepos();
            Produit produit = new Produit();
            produit.Prix = obj.Prix;
            produit.Description = obj.Description;
            produit.DateCreation = DateTime.Now;
            produit.Titre = obj.Nom;
            produit.IdCategorie   = obj.IdCategorie;
            produit.IdMarque = obj.IdMarque;
            source.Create(produit);
        }
    }
}
