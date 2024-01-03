

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity;

[Table("T_Commande")]
public class Commande
{
    public DateTime Date { get; set; }
    [Key]
    public int Id { get; set; }
    [Required]
    public int IdClient { get; set; }
    public Decimal Montant  { get; set; }
    public int NCommande { get; set; }

}