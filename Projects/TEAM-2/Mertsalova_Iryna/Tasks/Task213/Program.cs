using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task213
{
    class Program
    {
        //Користувач вводить з клавіатури число, необхідно перевернути його (число) і вивести на екран.
        //Примітка: Наприклад, користувач ввів число 12345.
        //На екрані має з'явитися число навпаки - 54321.
        static void Main(string[] args)
        {
            int numb, reverse = 0, rem;
            Console.Write(" Enter a number: ");
            numb = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Initial number --> " + numb);
            while (numb != 0)
            {
                rem = numb % 10;
                reverse = reverse * 10 + rem;
                numb /= 10;
            }
            Console.WriteLine(" Reversed number --> " + reverse + "\n");
        }
    }
}
