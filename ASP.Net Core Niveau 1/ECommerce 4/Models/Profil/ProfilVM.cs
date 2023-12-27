using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Profil
{
    public class ProfilVM
    {
        public string? Nom {  get; set; }
        public string? Prenom { get; set; }

        public List<ProfilCommandeVM>? Commandes { get; set; }
    }
    public class ProfilCommandeVM
    {
        public string? Description { get; set; }
        public double Prix {  get; set; }
        public string? Nom { get; set; }

    }
}
