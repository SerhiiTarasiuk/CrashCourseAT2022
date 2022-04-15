/*
Циклічність. Оператори While, do while. Цикл for, ключові слова break & continue

7. Написати програму, яка виводить на екран - наступну фігуру:
"*********************                                                                                                                                                                                                        
*                    *                                                                                                                                                                                                        
*                    *                                                                                                                                                                                                        
*                    *                                                                                                                                                                                                        
*                    *                                                                                                                                                                                                        
**********************                                                                                                                                                                                                        
ширина і висота фігури встановлюються користувачем з клавіатури.
*/

using System;

namespace ex215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введить довжину прямокутника ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введить висоту прямокутника ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if ((i == 0) || (i == b - 1)) Console.Write("*");
                    else if ((j == 0) || (j == a - 1)) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
