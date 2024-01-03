
namespace Models.Produit
{
    public class AdminProduitAjouterVM
    {
        public string Nom { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int IdCategorie { get; set; }
        public decimal Prix { get; set; }
        public string NomImage { get; set; } = string.Empty;
        public bool EstDisp { get; set; }
        public bool EstRemis { get; set; }
        public decimal RemiseEnDH { get; set; }
        public int IdMarque { get; set; }


    }
}
