
//Devoir 1 : Gestion des livres
//Cecilia Inoa
//Création de la solution : Gestion des livres
using AppConsoleLivres;


internal class Program
{
    private static void Main(string[] args)

    {

        Console.WriteLine("Solution Gestion des livres");
        Console.WriteLine();

        //Création trois instances de la classe Revue

       Revue revue1 = new Revue("Oh Magazine","Editora Listin Diario",300, 50, 2024);
       Revue revue2 = new Revue("Pandora","Caribe", 31, 357, 2024);
       Revue revue3 = new Revue("Mercado","Mercado Media Network", 210, 502, 2024);

       Console.WriteLine("*********Revues*********");
       Console.WriteLine();

        //Affichage des détails des objets Revue

       revue1.AfficherDetails();
       revue2.AfficherDetails();
       revue3.AfficherDetails();
       Console.WriteLine();

        //Création trois instances de la classe Roman

        Roman roman1 = new Roman("To All the Boys I've Loved Before", "Jenny Han", 384, "Romance");
        Roman roman2 = new Roman("All The Bright Places", "Jennifer Niven", 416, "Romance");
        Roman roman3 = new Roman("Paula", "Isabel Allende", 368, "Mémoire");

        Console.WriteLine("*********Romans*********");
        Console.WriteLine();
        //Affichage des détails des objets Roman

        roman1.AfficherDetails();
        roman2.AfficherDetails();
        roman3.AfficherDetails();

        Console.WriteLine();
        //Gérer les instances de ces classes

        List<Livre> livres = new List<Livre>(); //liste générique de type Livre
        livres.Add(revue1);
        livres.Add(revue2);
        livres.Add(revue3);
        livres.Add(roman1);
        livres.Add(roman2);
        livres.Add(roman3);
        Console.WriteLine("********Revues et romans********");
        Console.WriteLine();
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
        }
    }
}