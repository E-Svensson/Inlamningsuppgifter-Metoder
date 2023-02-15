using System;
namespace awda
{
    class Program
    {
        static bool Primtest(int tal)
        {
            bool primtal = true;

            for (int i = 1; i <= Math.Ceiling(Math.Sqrt(tal)); i++)
            {
                if (tal % i == 0 && i != 1 && tal > 2)
                    primtal = false;
            }

            return primtal;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nVälkommen till ett program som kan kolla om ett tal är ett primtal!");

            Console.Write("\nSkriv ett tal: "); int tal = int.Parse(Console.ReadLine());

            bool svar = Primtest(tal);

            if (svar == true)
                Console.WriteLine($"\n{tal} är ett primtal!");
            else
                Console.WriteLine($"\n{tal} är inte ett primtal!");
        }
    }
}