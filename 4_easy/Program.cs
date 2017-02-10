using System;

//Rules :

//"Your challenge for today is to create a random password generator.
//For extra credit, allow the user to specify the amount of passwords to generate.
//For even more extra credit, allow the user to specify the length of the strings he wants to generate."

namespace _4_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // 62 ch
            int nombre, longueur;
            Random random = new Random();

            Console.WriteLine("Combien de mots de passe générer ?");
            nombre = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLongueur des mots de passe ?");
            longueur = int.Parse(Console.ReadLine());

            Console.WriteLine(""); // on saute une ligne pour la présentation
            for (int i = 0; i < nombre; i++)
            {
                string mdp = "";
                for (int j = 0; j < longueur; j++)
                {
                    mdp += caracteres[random.Next(0, 63)];
                }
                Console.WriteLine(mdp);
            }
            Console.ReadKey();
        }
    }
}
