

using DAL.Entity;

namespace DAL.Repos
{
    public class ClientRepos
    {
        public void Create(Client entity)
        {
            MyDbContext myDbContext = new MyDbContext();
            myDbContext.Clients.Add(entity);
            myDbContext.SaveChanges();

        }
        public Client Read(int id)
        {
            MyDbContext myDbContext = new MyDbContext();
            return myDbContext.Clients.Find(id);
        }
        public List<Client> GetAll()
        {
            MyDbContext myDbContext = new MyDbContext();

            return myDbContext.Clients.ToList();
        }
    }
}
