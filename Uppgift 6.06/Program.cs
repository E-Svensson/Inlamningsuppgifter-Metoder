using System;
namespace Bah
{
    class Program
    {
        static string Kadabra(string sträng)
        {
            string[] ord = sträng.ToLower().Split();
            string Resultat = "";

            for (int i = 0; i < ord.Length; i++)
            {
                if (i % 2 == 0)
                    ord[i] = ord[i].ToUpper();
            }

            foreach (string s in ord)
                Resultat += s + " ";

            return Resultat;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSkriv ut en mening");

            Console.Write("\nSkriv här: "); string sträng = Console.ReadLine();

            string Resultat = Kadabra(sträng);

            Console.WriteLine("\n" + Resultat);
        }
    }
}