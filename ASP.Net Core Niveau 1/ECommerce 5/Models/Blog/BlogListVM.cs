namespace Models.Blog
{
    public class BlogListVM 
    {
        public int Id { get; set; }

        public string Titre  { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

         public DateTime Date { get; set;}
         public string Categorie { get; set;} = string.Empty;

    }
}
