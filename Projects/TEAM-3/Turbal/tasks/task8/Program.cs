// See https://aka.ms/new-console-template for more information


//8. Відомо, що 1 дюйм дорівнює 2.54 см. Розробити додаток, що переводять дюйми в сантиметри і навпаки. Діалог з користувачем реалізувати через систему меню.

float sm =0, dm = 0;

Console.WriteLine("If you want to convert centimeters to inches - press 1. \n If you want to convert inches to centimeters - press 2. \n Exit the program - 3.");
try
{
    int v = Convert.ToInt16(Console.ReadLine());
    switch (v)
    {
        case 1:
            {
                Console.WriteLine("How many centimeters to inches do you want to convert?");
                try
                {
                    sm = Convert.ToSingle(Console.ReadLine());
                    dm = 2.54f / sm;
                    Console.WriteLine($"{sm} centimeters is {dm} inches");
                }
                catch
                {
                    Console.WriteLine("Input is not a number!");
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("How many inches to centimeters do you want to convert?");
                try
                {
                    dm = Convert.ToSingle(Console.ReadLine());
                    sm = 2.54f * dm;
                    Console.WriteLine($"{dm} inches  is {sm} centimeters ");
                }
                catch
                {
                    Console.WriteLine("Input is not a number!");
                }
                break;
            }
        case 3:
            {
                Console.WriteLine("Exit program");
                break;
            }
        default:
                Console.WriteLine("We don't have such a name of menu!");
            break;
    }
}
catch 
{
    Console.WriteLine("Incorect input! We don't have such a name of menu!");
}



