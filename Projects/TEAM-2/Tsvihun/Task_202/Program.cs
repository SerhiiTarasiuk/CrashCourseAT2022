/*
202.
Напишіть програму, яка переводить гривні в $, Є.
*/
using System;

public class CurrencyExchange
{
    public static void Main(string[] args)
    {
        double usd_rate = 29.4;
        double eur_rate = 32.06;

        Console.WriteLine("Enter amount: ");
        double uah = double.Parse(Console.ReadLine());

        Console.WriteLine($"{uah} grn = {uah / usd_rate} dollars");
        Console.WriteLine($"{uah} grn = {uah / eur_rate} euros");
    }
}
