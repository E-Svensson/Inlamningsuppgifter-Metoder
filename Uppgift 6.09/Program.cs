using System;
namespace uhdrg
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool avslut = false;
            while (avslut == false)
            {
                Console.Clear();

                Console.WriteLine("\nVälkommen till detta programmet!");

                Console.WriteLine("\n1. Primtest");
                Console.WriteLine("2. Antal primtal som är mindre");
                Console.WriteLine("3. Avsluta programmet");

                Console.Write("\nVälj här: "); int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        ValPrimtest();
                        break;
                    case 2:
                        ValAntalPrimtal();
                        break;
                    default:
                        avslut = true;
                        break;
                }
            }
            static void ValPrimtest()
            {
                Console.Clear();

                Console.WriteLine("\nVälkommen till ett program som kan kolla om ett tal är ett primtal!");

                Console.Write("\nSkriv ett tal: "); int tal = int.Parse(Console.ReadLine());

                bool svar = Primtest(tal);

                if (svar == true)
                    Console.WriteLine($"\n{tal} är ett primtal!");
                else
                    Console.WriteLine($"\n{tal} är inte ett primtal!");

                Console.ReadKey();
            }
            static void ValAntalPrimtal()
            {
                Console.Clear();

                Console.Write("\nSkriv in ett heltal: "); int tal = int.Parse(Console.ReadLine());

                int antal = 0;

                for (int i = 0; i < tal; i++)
                    if (Primtest(i))
                        antal++;

                Console.WriteLine($"\nDet finns {antal} primtal som är mindre än {tal}");

                Console.ReadKey();
            }
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
        }
    }
}