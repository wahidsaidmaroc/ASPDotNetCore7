// See https://aka.ms/new-console-template for more information

using UICommande;

var a = 12;
Console.WriteLine("Hello, World!");

Console.WriteLine(a);


var listeCLient = new List<Client>();



for (int i = 0; i < 10; i++)
{
    var cl = new Client()
    { firstName = " Said" + i, lastName = "Khalid" + 1 };

    listeCLient.Add(cl);

}



var list = listeCLient.Count();


