using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_222___226
{
    class EX_222:MyFunc
    {
        //Написати перевантажені функції для знаходження коренів лінійного (a * x + b = 0) і квадратного (a * x2 + b * x + c = 0) рівнянь. Зауваження: у функції передаються коефіцієнти рівнянь.

        private double[] rootsOfEquations(double a, double b)//(a * x + b = 0)
        {
            double[] rez = new double[3];
            rez[0] = b / a;
            rez[2] = 1;
            return rez;
        }
        private double[] rootsOfEquations(double a, double b, double c)//(a * x2 + b * x + c = 0)
        {
            double[] rez = new double[3];
            double D = b * b - 4 * a * c;

            if (D == 0)
            {
                rez[0] = -b / 2 / a;
                rez[2] = 1;
            }
            else if (D > 0)
            {
                rez[0] = (-b - Math.Sqrt(D)) / 2 / a;
                rez[1] = (-b + Math.Sqrt(D)) / 2 / a;
                rez[2] = 2;
            }
            else
            {
                rez[2] = 0;
            }
            return rez;
        }
        public void main()
        {
            int varriantOfEquality = 0;
            int koofA, koofB, koofC = 0;
            double[] resultDobl = new double[3];

            Console.WriteLine("Choose the equality, print: \n1  -  (a * x + b = 0)\n2  -  (a * x2 + b * x + c = 0)");

            varriantOfEquality = EnterInteger();

            while (varriantOfEquality != 1 && varriantOfEquality != 2)//checking for right input
            {
                Console.WriteLine("Wrong number, choose one from nums upside");
                varriantOfEquality = EnterInteger();
            }

            if (varriantOfEquality == 1)//(a * x + b = 0)
            {
                Console.WriteLine("(a * x + b = 0)\n\nEnter coefficient: a");
                koofA = EnterInteger();
                Console.WriteLine("\nEnter coefficient: b");
                koofB = EnterInteger();

                resultDobl = rootsOfEquations(koofA, koofB);

            }
            else if (varriantOfEquality == 2)//(a * x2 + b * x + c = 0)
            {
                Console.WriteLine("(a * x2 + b * x + c = 0)\n\nEnter coefficient: a");
                koofA = EnterInteger();
                Console.WriteLine("\nEnter coefficient: b");
                koofB = EnterInteger();
                Console.WriteLine("\nEnter coefficient: c");
                koofC = EnterInteger();

                resultDobl = rootsOfEquations(koofA, koofB, koofC);
            }

            switch (resultDobl[2])
            {
                case 1:
                    Console.WriteLine($"\nThere is only one root: \nx = {resultDobl[0]}");
                    break;
                case 2:
                    Console.WriteLine($"\nThere are two roots: \nx1 = {resultDobl[0]} , x2 = {resultDobl[1]}");
                    break;
                case 0:
                    Console.WriteLine($"\nThere is no roots, sorry \n :(((");
                    break;
                default:
                    Console.WriteLine("There are problems in returned params");
                    break;
            }

            Console.ReadLine();
        }
    }
}
