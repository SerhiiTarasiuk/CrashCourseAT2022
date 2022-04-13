/*
Арифметичні операції, приведення типів, логічні операції, оператори if, else, switch

3. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.
*/

using System;

namespace ex208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double inch_in_sm = 2.54;
            double len;
            Console.WriteLine("Програма перерахунку дюймів в см і навпаки\nВиберіть напрямок розрахунку\n1 - Перерахувати дюйми в см\n2 - Перерахувати см в дюйми");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Введіть довжину в дюймах ");
                    len = double.Parse(Console.ReadLine());
                    Console.WriteLine("Довжина в см буде дорівнювати {0} см", len * inch_in_sm);
                    break;
                case 2:
                    Console.Write("Введіть довжину в дюймах ");
                    len = double.Parse(Console.ReadLine());
                    Console.WriteLine("Довжина в дюймах буде дорівнювати {0} дюйма", len * (1 / inch_in_sm));
                    break;
                default:
                    Console.WriteLine("Невірний вибір пункту меню\nПотрібно було вибрати або 1 або 2");
                    break;
            }
            Console.ReadKey();
        }
    }
}
