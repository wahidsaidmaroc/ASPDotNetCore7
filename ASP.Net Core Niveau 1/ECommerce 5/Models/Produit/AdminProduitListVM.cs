using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Produit
{
    public class AdminProduitListVM
    {
        public int Id { get; set; }
        public string NomProduit { get; set; }
        public string Categorie { get; set; }
        public decimal Prix { get; set; }
    }
}
