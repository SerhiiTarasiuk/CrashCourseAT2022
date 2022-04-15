using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//"6. Користувач вводить з клавіатури число, необхідно показати на екран суму його цифр.
//Примітка: Наприклад, користувач ввів число 12345. На екрані має з'явитися повідомлення про те, що сума цифр числа 15."
namespace _214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum, a = 0;
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                sum = num % 10;
                num /= 10;
                a += sum;
            }
            Console.WriteLine(a);
        }
    }
}
