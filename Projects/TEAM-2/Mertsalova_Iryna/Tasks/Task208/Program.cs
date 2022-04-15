using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task208
{
    class Program
    {
        //Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки.
        //Діалог з користувачем реалізувати через систему меню.
        static void Main(string[] args)
        {
            const float inches = 2.54f;
            int choise = 0;
            do
            {
                float number = 0;
                Console.WriteLine("\t ------------- M e n u -------------");
                Console.WriteLine("\t\t1. Centimeters in inches\n" +
                    "\t\t2. Inches in centimeters\n\tFor exit --> 0");
                Console.Write("\n\tChoose your choise: ");
                choise = Int32.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        {
                            Console.Write(" Enter centimeters: ");
                            number = float.Parse(Console.ReadLine());
                            Console.WriteLine("\n\t " + number + " centimeters --> " + (number / inches) + " inches\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" Enter inches: ");
                            number = float.Parse(Console.ReadLine());
                            Console.WriteLine("\n\t " + number + " inches --> " + (number * inches) + " centimeters\n");
                            break;
                        }
                }
            } while (choise != 0);
            Console.WriteLine("\n\tYou came out!");
        }
    }
}
