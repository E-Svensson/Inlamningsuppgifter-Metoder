using System;
namespace Bah
{
    class Program
    {
        static double Uträkning(double Bas, double Exponent)
        {
            double Svar = Math.Pow(Bas, Exponent);
            return Svar;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nVälkommen till ett program som kan räkna potenser!");

            Console.Write("\nVälj din bas: "); double Bas = double.Parse(Console.ReadLine());
            Console.Write("Välj din exponent: "); double Exponent = double.Parse(Console.ReadLine());

            double Svar = Uträkning(Bas, Exponent);

            Console.WriteLine($"\nSvaret blir då {Svar}");
        }
    }
}