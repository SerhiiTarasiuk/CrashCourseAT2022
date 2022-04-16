// See https://aka.ms/new-console-template for more information


//4. Напишіть програму, яка обчислює квадрат будь-якого, введеного числа.

float n = 0 , n_square = 0 ;

Console.WriteLine("Please, input number:");
try
{
    n = Convert.ToSingle(Console.ReadLine());
    n_square = n * n;
    Console.WriteLine($"n^2={n_square}");
    
    
}
catch
{
    Console.WriteLine("Input is not a number!");
}


