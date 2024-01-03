

using DAL.Repos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Commande;

namespace BLL
{
    public class CommandeService
    {

        public CommandeVM GetCommande(int id)
        {
            //Get Commande depuis la base de donnée

            CommandeRepos commandeRepos = new CommandeRepos();
            var commande = commandeRepos.Read(id);
           
            CommandeVM model = new CommandeVM
            {
                Montant = commande.Montant,
                Numero = commande.NCommande,
                Date = commande.Date
            };


            return model;
        }
    }
}
