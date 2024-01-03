

using Models.IndexHome;
using DAL.Repos;

namespace BLL.Home
{
    public class IndexService
    {

        public HomeVM GetPageHomeVM()
        {
            var data = new HomeVM();
            //Reccupre la liste de caroussel
            CarousselRepos carousselRepos = new CarousselRepos();


            foreach (var item in carousselRepos.All())
            {
                CarrouselHomeVM carrouselHomeVM = new CarrouselHomeVM();
                carrouselHomeVM.NomImage = item.NomImage;
                carrouselHomeVM.Id = item.Id;
                carrouselHomeVM.Titre = item.Titre;
                carrouselHomeVM.Description = item.Description;
                data.Carrousel.Add(carrouselHomeVM); 
            }

            return data;
        }


    }
}
