using System;
using System.IO;

//Rules :
//
//"Create a program that will ask the user's name, age, and username. Have it tell them the information back, in the format:
//Your name is (blank), you are (blank) years old, and your username is (blank).
//For extra credit, have the program log this information in a file to be accessed later."

namespace _1_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, username, information;
            int age;

            Console.WriteLine("What's your name ?");
            name = Console.ReadLine();

            Console.WriteLine("\nWhat's your age ?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat's your username ?");
            username = Console.ReadLine();

            information = "\nYour name is " + name + ", you are " + age + " years old and your username is " + username + ".";
            Console.WriteLine();

            StreamWriter writer = new StreamWriter("information.txt");
            writer.Write(information);
            writer.Close();

            Console.ReadKey();
        }
    }
}
