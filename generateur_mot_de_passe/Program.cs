namespace generateur_mot_de_passe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Generateur de mot de passe ---");

            // 1 - Demander la longueur du mot de passe (DemanderNombre) int longueur_mot_de_passe = ...
            int longueurMotDePasse = DemanderNombre("Longueur du mot de passe : ");

            // 2 - Générer un alphabet ex: "abcd1234"
            // 3 - Comment choisir un caractère aléatoire
            // 4 - Générer le mot de passe
            // 5 - Amélioration : choix alphabet
        }

        static int DemanderNombre(string question)
        {
            while (true)
            {
                // poser question
                Console.Write(question); // "Longueur du mot de passe souhaité ?"
                                         // récupérer la reponse
                string reponse = Console.ReadLine();

                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }

                // convertir
                // gérer l'erreur de conversion
                // boucler tant qu'on a pas reçu une réponse valide (qui contient que des chiffres)
            }
        }
    }
}
