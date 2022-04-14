using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.
namespace _209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a symbol :");
            char symb = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the number of chars :");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the direction: \n1. Horizontal \n2. Vertical");
            string choose = Convert.ToString(Console.ReadLine());
            switch (choose)
            {
                case "1":
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(symb);
                    }
                    Console.WriteLine();
                    break;
                case "2":
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(symb);
                    }
                    break;
            }

        }
    }
}
