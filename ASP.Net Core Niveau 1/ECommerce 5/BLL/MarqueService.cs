
using DAL.Entity;
using DAL.Repos;
using Models.Marque;

namespace BLL
{
    public class MarqueService
    {
        public List<ListMarqueVM> GetListMarques(
            )
        {

            var list = new List<ListMarqueVM>();
            MarqueRepos marqueRepos = new MarqueRepos();

            foreach (var item in marqueRepos.All())
            {
                ListMarqueVM listMarqueVM = new ListMarqueVM();
                listMarqueVM.Id = item.Id;
                listMarqueVM.Nom = item.Nom;
                list.Add(listMarqueVM);
            }

            return list;
        }


        
        public void Ajoutmarques(MarqueAjouterVM marqueAjouterVM )
        {
            MarqueRepos marqueRepos1 = new MarqueRepos();
            Marque marque = new Marque();
            marque.Nom = marqueAjouterVM.Nom;
            marqueRepos1.Create(marque);

        }
            
    }
}
