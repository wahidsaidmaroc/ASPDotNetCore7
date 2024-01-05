

using DAL.Entity;

namespace DAL.Repos;

public class ContactRepos
{
    public void Create(Contact contact)
    {
        MyDbContext myDbContext = new MyDbContext();
        myDbContext.Contacts.Add(contact);
        myDbContext.SaveChanges();
    }
    public List<Contact> All() {
        MyDbContext myDbContext = new MyDbContext();
        return myDbContext.Contacts.ToList();
        

    }
}
