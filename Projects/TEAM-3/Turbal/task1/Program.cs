// See https://aka.ms/new-console-template for more information


//1. Напишіть програму, яка обчислює середнє арифметичне двох чисел.

float a=0, b=0, mean = 0;

Console.WriteLine("Please, input first number:");
try
{
    a = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Please, input second number:");
    try
    {
        b = Convert.ToSingle(Console.ReadLine());
        mean = (a + b) / 2;
        Console.WriteLine($"Arithmetic mean of this two numbers is:{mean}");
    }
    catch
    {
        Console.WriteLine("Input is not a number!");
    }
    
}
catch
{
    Console.WriteLine("Input is not a number!");
}


