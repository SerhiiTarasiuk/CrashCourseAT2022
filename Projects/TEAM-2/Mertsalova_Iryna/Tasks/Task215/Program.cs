using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task215
{
    class Program
    {
        //Написати програму, яка виводить на екран - наступну фігуру:
        // *********************                                                                                                                                                                                                        
        // *                   *                                                                                                                                                                                                        
        // *                   *                                                                                                                                                                                                        
        // *                   *                                                                                                                                                                                                        
        // *                   *                                                                                                                                                                                                        
        // *********************                                                                                                                                                                                                        
        //ширина і висота фігури встановлюються користувачем з клавіатури.
        static void Main(string[] args)
        {
            char symb = ' ';
            int weight = 0, height = 0;

            Console.Write(" Enter a symb: ");
            symb = char.Parse(Console.ReadLine());
            Console.Write(" Enter a weight: ");
            weight = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter a height: ");
            height = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            outputWeight(symb, weight);
            for (int i = 0; i < height; i++)
            {
                Console.Write("\t* ");
                for (int j = 0; j < weight - 2; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine("*");
            }            
            outputWeight(symb, weight);
            Console.WriteLine();
        }

        private static void outputWeight(char symb, int weight)
        {
            Console.Write("\t");
            for (int i = 0; i < weight; i++)
            {
                Console.Write(symb + " ");
            }
            Console.WriteLine();
        }
    }
}
