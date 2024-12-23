﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation_CS_2024 // namespace
{
    static class outils // outils
    {
        public static int DemanderNombre(string question)
        {
            while (true)
            {
                // poser question
                Console.Write(question); // "Longueur du mot de passe souhaité ?"

                // récupérer la reponse
                string reponse = Console.ReadLine();

                try { int reponseInt = int.Parse(reponse); return reponseInt; }
                catch { Console.WriteLine("ERREUR : Vous devez rentrer un nombre"); }

                // convertir
                // gérer l'erreur de conversion
                // boucler tant qu'on a pas reçu une réponse valide (qui contient que des chiffres)
            }
        }

        public static int DemanderNombreEntre(string question, int min, int max)
        {
            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            // si le nombre est bien entre min et max => ERREUR / boucler ...
            Console.WriteLine($"ERREUR :  le nombre doit être compris entre {min} et {max}");
            return DemanderNombreEntre(question, min, max);
        }

        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue); // Méthode Récursive

            // ou 

            //int nombre = DemanderNombre(question);
            //if (nombre > 0)
            //{
            //    // valide
            //    return nombre;
            //}
            //Console.WriteLine($"ERREUR :  le nombre doit être supérieur à 0");

            //return DemanderNombrePositifNonNul(question);
        }
    }
}