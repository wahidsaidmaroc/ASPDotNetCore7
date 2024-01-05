using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{

    [Table("T_Ville")]

    public class Ville
    {
        [Key]
        [Column(name: "Id")]
        public int Id { get; set; }
        public string NomVille { get; set; } = string.Empty;
        public int CodePays { get; set; }
        
    }
}
