// See https://aka.ms/new-console-template for more information


//7. Дано натуральне число а (a <100). Напишіть програму, що виводить на екран кількість цифр в цьому числі і суму цих цифр

int a = 0, count_of_numbers = 0, sum = 0;

Console.WriteLine("Please, input a number :");
try
{
    a = Convert.ToInt16(Console.ReadLine());
    string s = Convert.ToString(a);
    count_of_numbers = s.Length;
    sum = 0;
    foreach (char c in s)
    {
        int digit = c - '0';
        sum += digit;
    }
    Console.WriteLine($"Number {a} contain {count_of_numbers} digits and their summ is {sum}");

}
catch 
{
    Console.WriteLine("Input is not an integer number!");
}


