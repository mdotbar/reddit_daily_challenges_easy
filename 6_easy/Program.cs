using System;

//Rules : 

//"Calculate pi."

namespace decimales_pi
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = 2;
            decimal x2 = 3;
            decimal x3 = 4;
            decimal pi = 3;

            for (int i = 0; i < 1000000; i++)
            {
                pi = pi + (4 / (x1 * x2 * x3));
                x1 += 2;
                x2 += 2;
                x3 += 2;

                pi = pi - (4 / (x1 * x2 * x3));
                x1 += 2;
                x2 += 2;
                x3 += 2;
            }

            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}
