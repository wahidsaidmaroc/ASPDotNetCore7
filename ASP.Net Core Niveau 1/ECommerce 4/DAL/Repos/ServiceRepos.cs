
using DAL.Entity;

namespace DAL.Repos
{
    public class ServiceRepos
    { 
        public int Create(Service service)
        {
            MyDbContext db = new MyDbContext();
            db.Services.Add(service);
            return db.SaveChanges();   
        } 
        public List<Service> All()
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Services.ToList();
        } 
        public Service Read(int id)
        {
            MyDbContext dbContext = new MyDbContext();
            return dbContext.Services.Find(id);
        } 
        public void Delete (int id)
        {
            MyDbContext dbContext = new MyDbContext();
            var obj = dbContext.Services.Find(id);
            dbContext.Services.Remove(obj);
        }

        public void Update(Service entity)
        {
            MyDbContext dbContext = new MyDbContext();
            dbContext.Services.Update(entity);
        }
    } 
}
