/*
205.
Введіть три числа і виведіть на екран значення суми і добуток цих чисел.
 */
using System;

public class Sum_Multiply
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1: ");
        var num1_str = Console.ReadLine();
        Console.WriteLine("Enter number 2: ");
        var num2_str = Console.ReadLine();
        Console.WriteLine("Enter number 3: ");
        var num3_str = Console.ReadLine();


        try
        {
            int num1 = Convert.ToInt32(num1_str);
            int num2 = Convert.ToInt32(num2_str);
            int num3 = Convert.ToInt32(num3_str);
            Console.WriteLine($"Summ of these 3 numbers = {num1 + num2 + num3}");
            Console.WriteLine($"Product of these 3 numbers = {num1 * num2 * num3}");
        }
        catch
        {
            Console.WriteLine("Not all are integer numbers !");
        }


    }
}