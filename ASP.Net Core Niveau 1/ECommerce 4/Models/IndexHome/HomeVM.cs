
namespace Models.IndexHome
{
    public class HomeVM
    {
        private List<CarrouselHomeVM> _Carrousel = new List<CarrouselHomeVM>();

        public List<CarrouselHomeVM> Carrousel
        {
            get { return _Carrousel; }
            set { _Carrousel = value; }
        }

        public List<ProduitHomeVM> Produit { get; set; }

    }

    public class CarrouselHomeVM
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Titre { get; set; } = string.Empty;

        public string NomImage { get; set; } = string.Empty;
    }
    public class ProduitHomeVM
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string NomImage { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }


}
