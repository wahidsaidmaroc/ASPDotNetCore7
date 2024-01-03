

using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("T_Utilisateur")]
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty; 
        public string Prenom { get; set; } = string.Empty;
        public string Compte { get; set; } = string.Empty;
        public string MotPasse { get; set; } = string.Empty;
    }
}
