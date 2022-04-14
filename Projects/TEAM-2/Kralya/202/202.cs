
double USD, EUR, UAH;

Console.WriteLine("\nExchange rate: \n\n1 USD = 29.253 UAH \n1 EUR = 31.762 UAH");

Console.WriteLine("\nEnter your amount of UAH's: ");
UAH = Convert.ToDouble(Console.ReadLine());

USD = UAH / 29.253;
EUR = UAH / 31.762;

Console.WriteLine("\nIt's: \n\t" + Math.Round(USD, 3) + " USD\n\t" + Math.Round(EUR, 3) + " EUR \n\nAccording to exchange rate for April 14th");
