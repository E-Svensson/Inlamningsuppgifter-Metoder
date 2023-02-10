using System;
namespace Bah
{
    class Program
    {
        static int Störst(int tal1, int tal2)
        {
            if (tal1 < tal2)
                return tal2;
            else
                return tal1;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            Console.Write("Tal 1: "); int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: "); int tal2 = int.Parse(Console.ReadLine());

            int störst = Störst(tal1, tal2);

            Console.WriteLine($"Det sörsta talet utav de två är {störst}");
        }
    }
}