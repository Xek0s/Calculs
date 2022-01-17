/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur

            // boucle sur le menu
            choix = "1";
            while (choix != "0") 
            {
                 // affiche le menu et saisi le choix
                 Console.WriteLine("Addition ....................... 1");
                 Console.WriteLine("Multiplication ................. 2");
                 Console.WriteLine("Quitter ........................ 0");
                 Console.Write("Choix :                          ");
                 choix = Console.ReadLine();
                // traitement des choix

                val1 = rand.Next(1, 10);
                val2 = rand.Next(1, 10);
                switch (choix)
                {
                    case "1": // choix de l'addition
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                        break;
                    case "2":// choix de la multiplication
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse 
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                        break;
                    case "0": // Demande d'arrêt du programme
                        break;
                    default: // Erreur de saisie 
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
        }
    }
}
