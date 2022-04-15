using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task220
{
    class Program
    {
        //Написати overload методи Add які в залежності від параметрів або додають цифрові значення,
        //або об'єднують введені тексти. Передбачити аргументи за замовчуванням і використання глобальних змінних.
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            string str1 = "", str2 = "";
            Console.Write(" Enter the first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter the second number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter the first str: ");
            str1 = Console.ReadLine();
            Console.Write(" Enter the second str: ");
            str2 = Console.ReadLine();
            Console.WriteLine("\t" + Add(num1, num2));
            Console.WriteLine("\t" + Add(str1, str2));
        }

        private static double Add(int num1, int num2)
        {
            Console.WriteLine("\n You use Add with int");
            return num1 + num2;
        }

        private static string Add(string str1, string str2)
        {
            Console.WriteLine("\n You use Add with string");
            return str1 + str2;
        }
    }
}
