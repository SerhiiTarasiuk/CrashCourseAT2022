﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221
{
    internal class Program
    {
        public string RemoveFromString(string a, string b)
        { 
            return a.Replace(b, "");
        }
        public string RemoveFromString(string a, int b, int c)
        {
            return a.Remove(b, c); 
        }
        static void Main(string[] args)
        {
            string text = "HelloWorld";
            string deletedText = "Hel";
            int del1 = 0;
            int del2 = 5;
            var p = new Program();
            var print0 = p.RemoveFromString(text, deletedText);
            var print1 = p.RemoveFromString(text, del1, del2);
            Console.WriteLine(print1);
            
        }
    }
}
