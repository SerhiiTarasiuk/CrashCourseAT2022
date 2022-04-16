// See https://aka.ms/new-console-template for more information


//6. Напишіть програму, яка перевіряє число, введене з клавіатури на парність.

int n;

Console.WriteLine("Please, input an integer number:");
try
{
    n = Convert.ToInt16(Console.ReadLine());
    if (n % 2 == 0)
    {
        Console.WriteLine($"The number {n} is even.");
    }
    else
    {
        Console.WriteLine($"The number {n} is odd.");
    }
}
catch 
{
    Console.WriteLine("Input is not an integer number!");
}


