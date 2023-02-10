using System;
namespace Bah
{
    class Program
    {
        static int Addera(int tal1, int tal2, int tal3)
        {
            int x = tal1 + tal2 + tal3;
            return x;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv tre tal");
            Console.Write("Tal 1: "); int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: "); int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Tal 3: "); int tal3 = int.Parse(Console.ReadLine());

            int summa = Addera(tal1, tal2, tal3);

            Console.WriteLine($"Summan av de tre talen blir {summa}");
        }
    }
}