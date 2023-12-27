using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("T_Caroussel")]
    public class Caroussel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string NomImage { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(60)]
        public string Titre { get; set; } = string.Empty;


    }

}
