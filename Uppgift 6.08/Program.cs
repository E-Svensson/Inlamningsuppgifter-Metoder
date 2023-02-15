using System;
namespace anujfga
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
            Console.Write("\nSkriv in ett heltal: "); int tal = int.Parse(Console.ReadLine());

            int antal = 0;

            for (int i = 0; i < tal; i++)
                if (Primtest(i))
                    antal++;

            Console.WriteLine($"\nDet finns {antal} primtal som är mindre än {tal}");
        }
    }
}