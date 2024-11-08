using Formation_CS_2024;

namespace generateur_mot_de_passe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Generateur de mot de passe ---");

            // 1 - Demander la longueur du mot de passe (DemanderNombre) int longueur_mot_de_passe = ...
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            Console.WriteLine();
            int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec : \n" +
                "1 - uniquement des minuscules\n" +
                "2 - des minuscules + MAJUSCULES\n" +
                "3 - des caractères spéciaux + chiffres\n" +
                "4 - des minuscules + MAJUSCULES + chiffres + caractère spéciaux\n" +
                "Votre choix : ", 1, 4);

            // 2 - Générer un alphabet ex: "abcd1234"
            // 3 - Comment choisir un caractère aléatoire
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpeciaux = "#&+-*$µ=_é~";
            //string alphabet = minuscules + majuscules + chiffres + caractereSpeciaux;
            string alphabet;
            string motDePasse = "";

            //Console.WriteLine("longueur: " + longueurAlphabet);
            //Console.WriteLine(alphabet[0]); // => 1er caractère de ma chaine
            //Console.WriteLine(alphabet[longueurAlphabet - 1]); // => dernier caractère de ma chaine
            Random rand = new Random();
            Console.WriteLine("Aléatoire : ");

            if (choixAlphabet == 1)
                alphabet = minuscules;
            else if (choixAlphabet == 2)
                alphabet = minuscules + majuscules;
            else if (choixAlphabet == 3)
                alphabet = caractereSpeciaux + chiffres;
            else
                alphabet = minuscules + majuscules + chiffres + caractereSpeciaux;

            int longueurAlphabet = alphabet.Length;
            // Boucler sur longueur MotDePasse
            for (int i = 0; i < longueurMotDePasse; i++)
            {
                int index = rand.Next(0, longueurAlphabet); // Rand exclu les valeur max, donc si on veut entre 1 et 8, il faut mettre l et non pas l-1
                motDePasse += alphabet[index];
            }
            // Console.WriteLine(alphabet[index]);
            // motDePasse += alphabet[index];
            Console.WriteLine("Mot de passe : " + motDePasse);

            // 4 - Générer le mot de passe
            // 5 - Amélioration : choix alphabet
        }
    }
}