
//Devoir 1 : Gestion des livres
//Cecilia Inoa
//Création de la solution : Gestion des livres
using AppConsoleLivres;


internal class Program
{
    private static void Main(string[] args)

    {

        Console.WriteLine("Solution Gestion des livres");

        //Création trois instances de la classe Revue

       Revue revue1 = new Revue("Oh Magazine","Editora Listin Diario",300, 50, 2024);
       Revue revue2 = new Revue("Pandora","Caribe", 31, 357, 2024);
       Revue revue3 = new Revue("Mercado","Mercado Media Network", 210, 502, 2024);

       //Affichage des détails de ces objets 

       revue1.AfficherDetails();
       revue2.AfficherDetails();
       revue3.AfficherDetails();
    }
}