using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.
namespace _208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am a program that converts centimeters to inches and vice versa. Select the operation you want to perform: \n1. Convert centimeters to inches. \n2. Convert inches to centimeters.");
            string choose = Console.ReadLine();

            Console.WriteLine("Type a length :");
            double length= Convert.ToDouble(Console.ReadLine());

            switch (choose)
            {
                case "1":
                    Console.WriteLine(Math.Round(length / 2.54, 2) + " inches");

                    break;

                case "2":
                    Console.WriteLine(Math.Round(length * 2.54, 2) + " centimeters");

                    break;
            }
        }
    }
}
