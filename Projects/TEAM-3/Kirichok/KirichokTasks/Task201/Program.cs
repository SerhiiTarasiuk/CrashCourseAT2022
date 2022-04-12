/*
201. програма, яка обчислює середнє арифметичне двох чисел.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task201
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter first number: ");
			double num1;
				double.TryParse(Console.ReadLine(), out num1);
			
			Console.WriteLine("Enter second number: ");
			double num2;
			double.TryParse(Console.ReadLine(), out num2);

			Console.WriteLine($"Average is: {(num1 + num2) / 2}");
			Console.ReadLine();
		}
	}
}
