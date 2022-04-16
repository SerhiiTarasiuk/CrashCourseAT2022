// See https://aka.ms/new-console-template for more information


//5. Введіть три числа і виведіть на екран значення суми і добуток цих чисел.

float n1 = 0, n2 = 0, n3 = 0, sum =0, mult = 0;

Console.WriteLine("Please, input first number:");
try
{
    n1 = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Please, input second number:");
    try 
    {
        n2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Please, input second number:");
        try
        {
            n3 = Convert.ToSingle(Console.ReadLine());
            sum = n1 + n2 + n3;
            mult = n1 * n2 * n3;
            Console.WriteLine($"The sum of the numbers is equal to {sum}, the product of the numbers is equal to {mult}");

        }
        catch
        {
            Console.WriteLine("Third input is not a number!");
        }
    }
    catch 
    { 
        Console.WriteLine("Second input is not a number!"); 
    }
}
catch 
{
    Console.WriteLine("First input is not a number!");
}


