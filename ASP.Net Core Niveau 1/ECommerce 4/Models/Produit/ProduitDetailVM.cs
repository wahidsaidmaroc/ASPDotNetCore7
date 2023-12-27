
namespace Models.Produit
{
    public class ProduitDetailVM
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Prix { get; set; }

    }
}
