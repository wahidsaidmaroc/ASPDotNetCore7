

using System.ComponentModel.DataAnnotations;

namespace Models.Client
{
    public class AdminCreateClientVM
    {
        [Required]
        [MinLength(3)]
        public string Nom { get; set; } = string.Empty;
        [Required]

        public string Prenom { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;


        public string Tel { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string MotPasse { get; set; } = string.Empty;
        public int IdPays { get; set; }

    }
}
