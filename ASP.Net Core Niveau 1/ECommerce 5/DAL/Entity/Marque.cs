
using System.ComponentModel.DataAnnotations.Schema;


namespace DAL.Entity
{
    [Table("T_Marque")]
    public class Marque
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
    }
}
