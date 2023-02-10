using System;
namespace Bah
{
    class Program
    {
        static string Längst(string sträng1, string sträng2)
        {
            if (sträng1.Length.CompareTo(sträng2.Length) < 0)
                return sträng2;
            else
                return sträng1;

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSkriv in två strängar");

            Console.Write("\nSträng 1: "); string sträng1 = Console.ReadLine();
            Console.Write("Sträng 2: "); string sträng2 = Console.ReadLine();

            string längst = Längst(sträng1, sträng2);

            Console.WriteLine($"\nDen längsta strängen utav de två är {längst}");
        }
    }
}