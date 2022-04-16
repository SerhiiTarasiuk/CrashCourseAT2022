// See https://aka.ms/new-console-template for more information


//2. Напишіть програму, яка переводить гривні в $, Є.

float grn = 0, dollars = 0, euro = 0;

Console.WriteLine("Please, input how many grivnias do yo have:");
try
{
    grn = Convert.ToSingle(Console.ReadLine());
    dollars = grn / 28.35f ;
    euro = grn / 30.55f;
    Console.WriteLine($"Our Dollar exchange rate is: 28.35 \n Our Euro exchange rate is: 30.55 \n You have: {dollars} dollars and {euro} euros! ");


}
catch
{
    Console.WriteLine("Input is not a number!");
}


