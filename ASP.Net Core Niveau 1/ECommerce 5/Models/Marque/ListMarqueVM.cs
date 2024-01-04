using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Marque
{
    public class ListMarqueVM
    {
        public int Id { get; set; }
        public string Nom { get; set; } = String.Empty;
        public string NomImg { get; set; } = String.Empty;
    }
}
