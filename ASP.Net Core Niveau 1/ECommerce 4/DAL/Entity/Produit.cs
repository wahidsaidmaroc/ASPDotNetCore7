

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity;

[Table("T_Produit")]
public class Produit
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    [MinLength(3)]
    [Column(Order = 1)]
    //Nvarchar(200)
    public string Titre { get; set; } = string.Empty;
    [Column(Order = 9)]
    public string Description { get; set; } = string.Empty;
    [Required]

    public decimal Prix { get; set; }
    [Required]
    public int IdCategorie { get; set; }
    public string NomImage { get; set; } = string.Empty;
    [Column("DateCreation", TypeName = "DateTime2")]
    public DateTime DateCreation { get; set; }
    public int Note { get; set; }
    public bool EstDispo { get; set; }
    public bool EstRemise { get; set; }
    public decimal RemiseEnDh { get; set; }

    public int IdMarque { get; set; }
}
