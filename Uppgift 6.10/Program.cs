using System;
namespace nbjgsbrk
{
    class Program
    {
        static int AntalTalIText(string para)
        {
            string[] strings = para.Split();
            int antal = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                bool ÄrDetEttTal = double.TryParse(strings[i], out double value);
                if (ÄrDetEttTal)
                    antal++;
                ÄrDetEttTal = false;
            }

            return antal;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSkriv in ett antal ord eller tal med mellanslag som mellanrum");

            Console.Write("\nSkriv här: "); string input = Console.ReadLine();

            int antal = AntalTalIText(input);

            Console.WriteLine($"\nDet du skrev innehöll {antal} tal");
        }
    }
}