
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Produit
{
    public class AdminProduitAjouterVM
    {
        [Required(ErrorMessage = "Saisir le nom de produit")]
        public string Nom { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description")]
        public string Description { get; set; } = string.Empty;
        [Required]
        public int IdCategorie { get; set; }

        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prix { get; set; }
        public string NomImage { get; set; } = string.Empty;
        public bool EstDisp { get; set; }
        public bool EstRemis { get; set; }
        public decimal RemiseEnDH { get; set; }
        [Required]
        public int IdMarque { get; set; }


    }
}
