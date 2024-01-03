using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Models.Commande
{
    public class CommandeFinVM
    {
        public string Nom { get; set; } = string.Empty; 
        public string Prenom { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;
        public int NumCommande { get; set; } 
        public double Montant { get; set; }

        public List<CommandeLigneFinVM> Ligne = new List<CommandeLigneFinVM>();
    }

    public class CommandeLigneFinVM
    {
        public string NomProduit { get; set; } = string.Empty;
        public double Prix { get; set; }
    }


}
