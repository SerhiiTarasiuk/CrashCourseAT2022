using System;

namespace Task202
{
    internal class Program
    {
        private static float SumUAH;
        private static float SumEUR;
        private static float SumUAH2;
        private static float SumUSD;
        private const float Kurs = 34.2F;        
        private const float Kurs2 = 32.5F;

        static void Main(string[] args)
        {
            Console.Write("Введіть суму в гривнях:");
            string UAH = Console.ReadLine();
            if (float.TryParse(UAH, out SumUAH))
            {
                SumEUR = SumUAH / Kurs;
                Console.WriteLine($"Сума в Євро:{SumEUR}");
            }
            else
            {
                Console.WriteLine("Не пиши фігню");
            }

            Console.ReadLine();

            Console.Write("Введіть суму в гривнях2:");
            string UAH2 = Console.ReadLine();
            if (float.TryParse(UAH2, out SumUAH2))
            {
                SumUSD = SumUAH2 / Kurs2;
                Console.WriteLine($"Сума в Долларах:{SumUSD}");
            }
            else
            {
                Console.WriteLine("Не пиши фігню 2 ");
            }
             
            Console.ReadLine();

        }
    }
}