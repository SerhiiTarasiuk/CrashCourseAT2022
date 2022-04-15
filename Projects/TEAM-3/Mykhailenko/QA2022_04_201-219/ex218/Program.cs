/*
Масиви даних
3. Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.
*/

using System;

namespace ex218
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 1;
			int[] arr = new int[10];

			Console.WriteLine("Введіть десять числових елементів масиву");
			for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());
			Console.Write("Елементи масиву які повторюються ");
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[i] == arr[j])
					{
						if ((x == 1) && (arr[j] != '\0')) { Console.Write("{0} ", arr[i]); }

						arr[j] = '\0';
						x++;
					}
				}
				x = 1;
			}
			Console.ReadKey();
		}
	}
}
