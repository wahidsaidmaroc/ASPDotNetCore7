using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Panier
{
    public class LignPanier
    {
        public int IdProduit { get; set; }
        public double PrixProduit { get; set; }
        public int Quantite{ get; set; }
        public double Total { get { return Quantite * PrixProduit; } }
        public string Description { get; set; } = string.Empty;
        public string NomImage { get; set; } = string.Empty;

    }
}
