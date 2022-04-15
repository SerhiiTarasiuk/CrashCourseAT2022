// See https://aka.ms/new-console-template for more information


//10. Користувач вводить з клавіатури число - програма повинна показати скільки в даному числі цифр. Число вводиться повністю в одну змінну.
//Примітка: Наприклад, користувач ввів число 11123445555. На екрані має з'явитися повідомлення про те, що в числі 5 цифр.

ulong n = 0, digit = 0;
int count = 0;

int[] array_is_present = new int[10];
for (int i = 0; i < 10; i++)
{
    array_is_present[i] = 0;
}

Console.WriteLine("Enter your number:");
try
{
    count = 0;
    n = Convert.ToUInt64(Console.ReadLine());
    while (n > 0)
    {
        digit = n % 10;
        if (array_is_present[digit] == 0)
        {
            count++;
            array_is_present[digit]++;
        };
        n /= 10;
    }
    
    Console.WriteLine($"The number has {count} unique digits.");


}
catch
{
    Console.WriteLine("Incorrect number!");
}






