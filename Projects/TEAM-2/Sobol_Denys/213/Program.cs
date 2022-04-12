using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num>0)
            {
                sum = num % 10;
                num /= 10;
                Console.Write(sum);
            }
        }
    }
}
