// See https://aka.ms/new-console-template for more information


//9. Розробити програму, яка виводить на екран горизонтальну лінію з символів. Кількість символів, який використовувати символ, і яка буде лінія - вертикальна, або горизонтальна - вказує користувач.

int n = 0;
char c =' ';
char direction = ' ';

Console.WriteLine("How many symbols do you want to print?");
try
{
    n = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("What symbol do you want to print? Please enter only ONE symbol!");
    try
    {
        c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("If you want a horizontal line - press 'h', if you want a vertical line - press 'v'");
        try
        {
            direction = Convert.ToChar(Console.ReadLine());
            switch (direction)
            {
                case 'h':
                    {
                        string s = "";
                        for (int i = 0; i < n; i++)
                        {
                            s += c;
                        }
                        Console.WriteLine(s);
                        break;
                    }
                case 'v':
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(c);
                        }

                        break;
                    }
                default:
                    Console.WriteLine("You write a wrong direction! We cant print this...");
                    break;

            }
        }
        catch
        {
            Console.WriteLine("You write a wrong direction! We cant print this...");
        }
    }
    catch
    {
        Console.WriteLine("You write a string not a char!");
    }
}
catch
{
    Console.WriteLine("Incorrect number!");
}






