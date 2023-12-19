
namespace Models.Produit;

public class ProduitListVM
{
    public ProduitListVM()
    { }
    public ProduitListVM(int Id, 
        string Nom,
        string Description,
        double Prix
        )
    {
        this.Id = Id;
        this.Nom = Nom;
        this.Description = Description;
        this.Prix = Prix;
    }
    public int Id { get; set; }
    public string Nom { get; set; }=String.Empty;
    public string Description { get; set; } = String.Empty;
    public double Prix { get; set; }

}


