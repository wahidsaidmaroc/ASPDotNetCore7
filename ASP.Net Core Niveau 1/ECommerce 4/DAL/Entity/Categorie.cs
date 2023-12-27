
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity;

[Table("T_Categorie",Schema="dbo")]
public class Categorie
{
    [Key]
    public int Id { get; set; }


    [Column("Categorie")]
    [MaxLength(200)]
    [Required]
    public string NomCategorie { get; set; } = string.Empty;
    [MaxLength(400)]

    public string Description { get; set; } = string.Empty;
    [MaxLength(100)]
    public string NomImage { get; set; } = string.Empty;
}
