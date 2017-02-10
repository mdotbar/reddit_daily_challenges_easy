using System;
using System.IO;

//Rules : 

//"Create a program which is password protected, and won't open unless the correct user and password is given.
//For extra credit, have the user and password in a separate txt file.
//For even more extra credit, break into your own program."

namespace _5_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, mdp;
            string test_id = "";
            string test_mdp = "";
            string[] lignes = File.ReadAllLines("identifiant.txt");
            id = lignes[0];
            mdp = lignes[1];

            while (test_id != id || test_mdp != mdp)
            {
                Console.Write("Identifiant : ");
                test_id = Console.ReadLine();
                Console.Write(Environment.NewLine);

                Console.Write("Mot de passe : ");
                test_mdp = Console.ReadLine();
                Console.Write(Environment.NewLine);

                if (test_id != id)
                {
                    Console.WriteLine("Identifiant incorrect.");
                }
                else if (test_mdp != mdp)
                {
                    Console.WriteLine("Mot de passe incorrect.");
                }
                else
                {
                    Console.WriteLine("Vous êtes connecté.");
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
