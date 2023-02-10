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
        static int Addera(int tal1, int tal2, int tal3)
        {
            int x = tal1 + tal2 + tal3;
            return x;
        }
        public static void MenyvalAddera()
        {
            Console.Clear();

            Console.WriteLine("\nSkriv tre tal");
            Console.Write("\nTal 1: "); int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: "); int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Tal 3: "); int tal3 = int.Parse(Console.ReadLine());

            int summa = Addera(tal1, tal2, tal3);

            Console.WriteLine($"\nSumman av de tre talen blir {summa}");

            Thread.Sleep(3000);
            Console.WriteLine("\nTryck på enter för att fortsätta");

            Console.ReadLine();
        }
        public static void MenyvalStörstaTalet()
        {
            Console.Clear();

            Console.WriteLine("\nSkriv in två tal");
            Console.Write("\nTal 1: "); int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: "); int tal2 = int.Parse(Console.ReadLine());

            int störst = Störst(tal1, tal2);

            Console.WriteLine($"\nDet sörsta talet utav de två är {störst}");

            Thread.Sleep(3000);
            Console.WriteLine("\nTryck på enter för att fortsätta");

            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            bool Avslut = false;
            while (Avslut == false)
            {
                Console.Clear();

                Console.WriteLine("\n1. Addera tre tal");
                Console.WriteLine("2. Största talet av två");
                Console.WriteLine("3. Avsluta programmet");

                Console.Write("\nVälj här: "); int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        MenyvalAddera();
                        break;
                    case 2:
                        MenyvalStörstaTalet();
                        break;
                    default:
                        Avslut = true;
                        break;
                }
            }

        }
    }
}