/*
 207. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.
  */
using System;

namespace Task_208
{
    class Program
    {
        static void Main(string[] args)
        {
            const double inch = 2.54;

            Console.WriteLine("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose convertion:\n1 - Inches >> Cm\n2 - Cm >> Inches ");
            string choice = Console.ReadLine();

            switch (choice) {
                case "1": {
                    Console.WriteLine($"{number} Inches = {number * inch} Cm");
                    break;
                }
                case "2": {
                    Console.WriteLine($"{number} Cm = {number / inch} Inches");
                    break;
                }

                default: {
                    Console.WriteLine("Choose 1 or 2");
                    break;
                }

            }

        }
    }
}
