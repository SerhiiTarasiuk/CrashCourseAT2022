using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex304
{
    internal class StringRow
    {
        string str;
        char tmp = ' ';
        public StringRow()
        {
            str = new string (' ',80);
        }

        public StringRow (int _len) 
        {
            str = new string (' ',_len);
        }

        public StringRow (string _str)
        {
            this.str = _str;
        }
        public static void Write(string _s="")
        {
            Console.Write(_s);
        }

        public static void WriteLine(string _s="")
        {
            Console.WriteLine(_s);
        }
        public static string ReadLine() 
        {
            return Console.ReadLine();
        }

        public override string ToString()
        {
            return this.str;
        }

        public static ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }
    }
}
