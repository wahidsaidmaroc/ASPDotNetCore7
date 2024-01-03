
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("T_Panier")]
    public class Panier
    {
        [Key]
        public int Id { get; set; }
        public int IdClient { get; set; }
        public DateTime Date { get; set; }
        public bool Etat { get; set; }
        public Decimal Total { get; set; }

    }
}
