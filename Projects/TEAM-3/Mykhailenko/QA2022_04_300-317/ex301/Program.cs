/*
ООП
Класи і конструктори

Написати клас Товар. Також реалізувати клас магазин. Передбачити можливість отримання товару на баланс і продажу товару.
*/
using System;

namespace ex301
{
    internal class Program
    {
        static void Menu(Shop _s)
        {
            int ask = 0;
            do 
            {
                Console.WriteLine("1. Show all products in shop");
                Console.WriteLine("2. Add product in shop");
                Console.WriteLine("3, Bay product in shop");
                Console.WriteLine("0, Exit");
                ask = int.Parse(Console.ReadLine());
                switch (ask) 
                { 
                    case 1: 
                        _s.ShowAllOProductInShop();
                        break;
                    case 2:
                        Console.Write("Input Name of product : ");
                        string _n1 = Console.ReadLine();
                        Console.Write("Input Price of product : ");
                        double _p1 = Double.Parse(Console.ReadLine());
                        Console.Write("Input count of product : ");
                        double _o1 = Double.Parse(Console.ReadLine());
                        _s.Add_product(_n1, _p1, _o1);
                        _s.ShowAllOProductInShop();
                        break;
                    case 3:
                        Console.Write("Input Name of product : ");
                        string _n2 = Console.ReadLine();
                        Console.Write("Input Price of product : ");
                        double _p2 = Double.Parse(Console.ReadLine());
                        Console.Write("Input count of product : ");
                        double _o2= Double.Parse(Console.ReadLine());
                        Console.WriteLine(_s.Bay_Product(_n2 , _p2, _o2));
                        _s.ShowAllOProductInShop();
                        break;
                    default: break;
                }
            }
            while (ask!=0);
        }
        static void Main(string[] args)
        {
            Shop s = new Shop();
            s.Add_product("Apple", 15.5, 25);
            s.Add_product("Bread", 21, 45);
            s.Add_product("Butter", 45, 15);
            s.Add_product("Tea", 40, 5);
            Menu(s);
            Console.ReadKey();
        }
    }
}
