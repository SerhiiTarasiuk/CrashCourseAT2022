using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Напишіть програму, яка обчислює середнє арифметичне двох чисел.
namespace Tasks
{
    class Program
    {
        static int Avrg(int a, int b)
        {
            return (a + b) / 2; 
        }             
        static void Main()
        {

            Console.WriteLine(Avrg(7, 3));



        }
    }
}
