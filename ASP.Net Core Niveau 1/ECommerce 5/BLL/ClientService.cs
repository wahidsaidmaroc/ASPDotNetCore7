
using DAL.Entity;
using DAL.Repos;
using Models.Client;

namespace BLL
{
    public class ClientService
    {

        public List<ClientListVM> GetListClient()
        { 
            ClientRepos clientRepos = new ClientRepos();
            List<ClientListVM> list = new   List<ClientListVM>();

            foreach (var item in clientRepos.GetAll())
            {
                ClientListVM obj = new ClientListVM
                {
                    Email = item.Email,
                    Img = item.Img,
                    Id = item.Id,
                    Nom = item.Nom,
                    Prenom = item.Prenom,
                    Tel = item.Tel,
                };
                list.Add(obj);
            }


            return list;
        }


        public void AjouterClient(AdminCreateClientVM model)
        {
            ClientRepos repos = new ClientRepos();
            Client client = new Client();
            client.Email = model.Email;
            client.Tel = model.Tel;
            client.Nom = model.Nom;
            client.Prenom = model.Prenom;
            client.MotPasse = model.MotPasse;

            repos.Create(client);

        }
    }
}
