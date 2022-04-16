// See https://aka.ms/new-console-template for more information


//1. Написати програму, яка виводить вміст масиву навпаки.
//Приклад: масив 23 11 6 перетворюється в 6 11 23.


int count =0;
bool corect_input = true;

//зчитуємо довільну кількість елементів масиву,які записані в один рядок і розділені пробілами
Console.WriteLine("Please, input elements of array in one line with spaces between them:");
string s = Console.ReadLine();
string[] elements = s.Split(' ');
count = elements.Length;

for (int i=count-1; i>=0; i--)
{
    int flag = 0;
    bool is_number = int.TryParse(elements[i], out flag);
    if (is_number == false)
        corect_input = false;
    Console.Write("{0} ", elements[i]);
}

Console.WriteLine();

if (corect_input == false)
    { Console.WriteLine("One or more elements in the array you entered is not a number!"); }











