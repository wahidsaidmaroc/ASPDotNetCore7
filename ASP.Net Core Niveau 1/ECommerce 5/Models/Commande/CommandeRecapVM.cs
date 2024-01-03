using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models.Commande
{
    public class CommandeRecapVM
    {
        public List<LigneCommandeRecapVM> Lp = new List<LigneCommandeRecapVM>();

        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;


    }
    public class LigneCommandeRecapVM
    {
        public string Nom { get; set; }
        public int Qte { get; set;}
        public decimal Prix { get; set;}

    }

}
