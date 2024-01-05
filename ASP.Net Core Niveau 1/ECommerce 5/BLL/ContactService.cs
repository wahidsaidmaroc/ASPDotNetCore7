using DAL.Entity;
using DAL.Repos;
using Models.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContactService
    {

        public void  Ajouter(FormulaireVM model)
        {
            Contact contact = new Contact()
            {
                Adresse = model.Adresse,
                CodePostale = model.CodePostale,
                Email = model.Email,
                Nom = model.Nom,
                Prenom = model.Prenom
            };
            contact.DateCreation = DateTime.Now;
            ContactRepos contactRepos = new ContactRepos();
            contactRepos.Create(contact);
        }

        public List<ContactListvm> GetList()
        {
            ContactRepos contactRepos = new ContactRepos(); 
            List<ContactListvm> listvms = new List<ContactListvm>(); ;

            foreach (var item in contactRepos.All())
            {
                ContactListvm contactListvm = new ContactListvm
                {
                    DateCreation = item.DateCreation,
                    Nom = item.Nom,
                    Prenom = item.Prenom,
                    Id = item.Id
                };
                listvms.Add(contactListvm);
            }

            return listvms;
            
        }

    }
}
