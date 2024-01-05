using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Paiement
{
    public class PaiementVm
    {
        public string Nom { get; set; } = string.Empty;
        public int NumCarte { get; set; }
        public int Cvv { get; set; }
        public int DateExpAnnee { get; set; }
        public int DateExpMois { get; set; }

    }
}
