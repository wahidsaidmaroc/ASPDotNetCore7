using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity;

[Table("T_Client")]
public class Client
{
    public int Id { get; set; }
    public string Nom { get; set; } = string.Empty;
    public string Prenom { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Tel { get; set; } = string.Empty;
    public string Img { get; set; } = string.Empty;
    public string MotPasse { get; set; } = string.Empty;


}
