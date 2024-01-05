using System.ComponentModel.DataAnnotations;

namespace Models.Contact
{
    public class FormulaireVM
    {
        [Required(ErrorMessage = "Tapez votre nom")]
        [MinLength(2)]
        public string Nom { get; set; } = string.Empty;
        [Required(ErrorMessage = "Tapez votre Prénom")]
        [MinLength(2)]
        public string Prenom { get; set; } = string.Empty;
        [Required(ErrorMessage = "Tapez votre Adressse Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MinLength(10)]
        public string Adresse { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.PostalCode)]
        public string CodePostale { get; set; } = string.Empty;
        public string Ville { get; set; } = string.Empty;

    }

}
