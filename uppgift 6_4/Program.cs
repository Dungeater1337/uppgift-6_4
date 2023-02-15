using System;

namespace uppgift6_4
{
    class Program
    {
        static void Main(string[] agrs)
        {

            double värde = Potens();
            Console.WriteLine("Värdet blir " + värde);

        }

        static double Potens()
        {
            Console.WriteLine("Skriv in basen till ditt tal");
            double bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Bra! Skriv nu in exponent till basen");
            double exponent = int.Parse(Console.ReadLine());

            return Math.Pow(bas, exponent);
        }
    }
}