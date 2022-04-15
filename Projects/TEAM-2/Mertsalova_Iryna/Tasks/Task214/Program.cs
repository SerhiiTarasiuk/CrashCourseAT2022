using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task214
{
    class Program
    {
        //Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
        //Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, 
        //що сума цифр числа 15.
        static void Main(string[] args)
        {
            int num, sum = 0, m;
            Console.Write("Enter a number: ");
            num = Int32.Parse(Console.ReadLine());
            while (num > 0)
            {
                m = num % 10;
                sum = sum + m;
                num = num / 10;
            }
            Console.WriteLine("Sum is = " + sum);
        }
    }
}
 