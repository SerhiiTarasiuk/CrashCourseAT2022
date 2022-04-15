using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Напишіть програму, яка переводить гривні в $, Є.
namespace Tasks
{
    class Program
    {
        static float ConvertToDollar(int a)
        {
            return (float) (a / 29.39);



        }

        static float ConvertToEuro(int b)
        {

            return (float) (b / 31.97);

        }



        static void Main()
        {

            var a = ConvertToDollar(100);

            Console.WriteLine(a);

            var b = ConvertToEuro(500);

            Console.WriteLine(b);


        }

    }
}
