using DAL.Repos;
using Models.Categorie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategorieService
    {
        public List<CategorieListViewModel> ListDetailVM()
        {
            //Pour recupere la liste des categorie
            var categorieRepos = new CategorieRepos();


            List<CategorieListViewModel> listViewModels = new List<CategorieListViewModel>();

            foreach (var item in categorieRepos.All())
            {
                CategorieListViewModel categorieListViewModel = new CategorieListViewModel();
                categorieListViewModel.Id = item.Id;
                categorieListViewModel.Nom = item.NomCategorie;
                categorieListViewModel.Description = item.Description;
                categorieListViewModel.NomImage = item.NomImage;
                listViewModels.Add(categorieListViewModel);
            }
            return listViewModels;
        }
    }
}
