/*
204.
Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.
*/
using System;

public class SquareNubmer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        try
        {
            double number = Double.Parse(Console.ReadLine());
            double sqr_number = number * number;
            Console.WriteLine($"Square nubmer is {sqr_number}");
        }
        catch
        {
            Console.WriteLine("NOT number !");
        }


    }
}