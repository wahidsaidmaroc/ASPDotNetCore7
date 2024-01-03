using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("T_Blog")]
    public class Blog
    {
        [MaxLength(100)]
        public string Categorie { get; set;} = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Key]
        [Column(name:"Id")]
        public int CodeTable { get; set; }
        [MaxLength(100)]
        public string Titre { get; set; } = string.Empty;

        public DateTime DateCreation { get; set; }

    }
}
