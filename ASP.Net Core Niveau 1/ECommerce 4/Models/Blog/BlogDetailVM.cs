using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Blog
{
    public class BlogDetailVM
    {
        public string Titre  { get; set; } = string.Empty;  
        public string Description { get; set; }  =string.Empty; 
        public DateTime Date { get; set; }
        public string Categorie { get; set; } = string.Empty;        

    }
}
