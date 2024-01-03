using DAL.Entity;

namespace DAL.Repos
{
    public class BlogRepos
    {
        public void Create(Blog entity)
        {
            MyDbContext myDbContext = new MyDbContext();
            myDbContext.Blogs.Add(entity);
            myDbContext.SaveChanges();

        }
        public Blog Read(int id)
        {
            MyDbContext myDbContext = new MyDbContext();
            return myDbContext.Blogs.Find(id);
        }

        public List<Blog> GetAll()
        {
            MyDbContext myDbContext = new MyDbContext();

            return myDbContext.Blogs.ToList() ;
        }
    }
}
