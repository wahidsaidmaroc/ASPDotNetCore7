using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_PanierProduit")]
    public class PanierProduit
    {
        [Key]
        public int Id { get; set; }
        public int IdPanier { get; set; }
        public int IdProduit { get; set; }
        public int Quantiter { get; set; }
        public decimal Prix { get; set;}
    }
}
