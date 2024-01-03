using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Commande
{
    public class CommandeVM
    {
        public DateTime Date  { get; set; }
        public int Numero  { get; set; }
        public decimal Montant { get; set; }
        public Double Total { get; set; }
        public List<LigneCommandeVM> LigneCommandes = new List<LigneCommandeVM>();

    }
}
