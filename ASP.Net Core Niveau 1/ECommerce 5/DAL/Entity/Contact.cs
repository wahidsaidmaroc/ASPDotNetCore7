

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("T_Contact")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public string CodePostale { get; set; } = string.Empty;
        public string IdVille { get; set; } = string.Empty;
        public DateTime DateCreation { get; set; }
    }
}
