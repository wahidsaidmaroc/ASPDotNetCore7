

using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity;

[Table("T_Pays")]
public class Pays
{
    [Key]
    [Column(name: "Id")]
    public int Code { get; set; }
    [Required]
    public string Nom { get; set; } = string.Empty;
}
