using Formation_CS_2024;

namespace generateur_mot_de_passe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Generateur de mot de passe ---");

            // 1 - Demander la longueur du mot de passe (DemanderNombre) int longueur_mot_de_passe = ...
            // int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");

            // 2 - Générer un alphabet ex: "abcd1234"
            // 3 - Comment choisir un caractère aléatoire
            string alphabet = "abcd1234";
            int l = alphabet.Length;
            Console.WriteLine("longueur: " + l);
            Console.WriteLine(alphabet[0]); // a
            Console.WriteLine(alphabet[l-1]); // 4
            Random rand = new Random();
            int index = rand.Next(0, l); // Rand exclu les valeur max, donc si on veut entre 1 et 8, il faut mettre l et non pas l-1
            Console.Write("Aléatoire : ");
            Console.WriteLine(alphabet[index]);

            // 4 - Générer le mot de passe
            // 5 - Amélioration : choix alphabet
        }
    }
}