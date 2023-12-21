using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Commande
{
    public class LigneCommandeVM
    {
        public int Code { get; set; }
        public String Description { get; set; }=string.Empty;
        public int Quantite { get; set; }
        public Double Montant { get { return Quantite * PU; } }
        public Double PU { get; set; }
        public string NomImage { get; set; }

    }
}
