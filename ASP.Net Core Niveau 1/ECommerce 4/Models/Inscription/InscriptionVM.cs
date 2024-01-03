using System.ComponentModel.DataAnnotations;

namespace Models.Inscription
{
    public class InscriptionVM
    {
        [Required(ErrorMessage = "Tapez votre nom")]
        [MinLength(3)]
        public string Nom { get; set; } = string.Empty;
        [Required(ErrorMessage = "Tapez votre Prenom")]
        [MinLength(3)]
        public string Prenom { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tapez votre Mail")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tapez votre Telephone")]


        public string Tel { get; set; } = string.Empty;

        #region "Gestion  Mot de passe"

        [Required(ErrorMessage = "Tapez votre Mot de passe")]
        [DataType(DataType.Password)]
        public string MotDePasse1 { get; set; } = string.Empty;
        
        
        [Required(ErrorMessage = "Tapez votre Mot de passe")]
        [DataType(DataType.Password)]
        [Compare("MotDePasse1")]
        public string MotDePasse2 { get; set; } = string.Empty;

        #endregion

        [Required(ErrorMessage = "Tapez votre Adresse")]
        public string Adresse { get; set; } = string.Empty;


    }
}
