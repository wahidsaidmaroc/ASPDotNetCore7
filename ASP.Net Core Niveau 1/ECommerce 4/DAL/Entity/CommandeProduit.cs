using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_CommandeProduit")]
    public class CommandeProduit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdProduit { get; set; }
        public Decimal Prix { get; set; }
        public int Qnt { get; set; }
        public int IdCommande { get; set; }
    }
}
