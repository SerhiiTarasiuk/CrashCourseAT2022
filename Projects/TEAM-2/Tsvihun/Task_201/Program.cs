/*
201.
Напишіть програму, яка обчислює середнє арифметичне двох чисел.
*/
using System;

public class Average
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Average is: {(num1 + num2) / 2}");

    }
}
