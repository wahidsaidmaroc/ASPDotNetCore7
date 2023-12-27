namespace Models.Profil;

public class MesCommandesVM
{
    public int Id { get; set; }
    public  DateTime Date{ get; set; }
    public string Statut { get; set; } = String.Empty;
    public double Montant { get; set; }
}
