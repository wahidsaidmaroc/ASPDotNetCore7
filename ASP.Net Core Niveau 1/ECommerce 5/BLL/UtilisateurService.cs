using DAL.Repos;
using Models.Auth;


namespace BLL
{
    public class UtilisateurService
    {
        public UserSession? VerifierCompte(UserAuthVM obj)
        {
            UtilisateurRepos utilisateurRepos = new UtilisateurRepos();
            var result = utilisateurRepos.All()
                        .Where(a =>a.MotPasse == obj.MotPasse && a.Compte == obj.Compte)
                        .FirstOrDefault();
            if (result != null)
            {
                UserSession userSession = new UserSession();
                userSession.AdresseMail = result.Compte;
                userSession.Id = result.Id;
                userSession.Nom = result.Nom;
                return userSession;
            }
            return null;
        }
    }
}
