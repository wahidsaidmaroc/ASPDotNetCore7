using DAL.Entity;
using DAL.Migrations;
using DAL.Repos;
using Models.Categorie;


namespace BLL;

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

    public List<Models.Categorie.AdminListCategorieMV> AdminListVM()
    {
        //Pour recupere la liste des categorie
        var categorieRepos = new CategorieRepos();


        List<AdminListCategorieMV> listViewModels = new List<AdminListCategorieMV>();

        foreach (var item in categorieRepos.All())
        {
            AdminListCategorieMV categorieListViewModel = new AdminListCategorieMV();
            categorieListViewModel.Id = item.Id;
            categorieListViewModel.Nom = item.NomCategorie;
            categorieListViewModel.NomImg = item.NomImage;
            listViewModels.Add(categorieListViewModel);
        }
        return listViewModels;
    }


    public void Ajouter(Models.Categorie.AdminCreateCategorie obj)
    {
        //Pour recupere la liste des categorie
        var categorieRepos = new CategorieRepos();
        Categorie categorie = new Categorie
        {
            NomCategorie = obj.Nom,
            Description = obj.Description,
            NomImage = obj.NomImage
        };
        categorieRepos.Create(categorie);

    }

}
