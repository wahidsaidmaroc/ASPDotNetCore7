using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity;
[Table("T_Service")]
public class Service
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(300)]
    public string Titre { get; set; }=string.Empty;
    public string Description { get; set; }= string.Empty;  
}
