using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220
{
    internal class Program
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine(p.Add("dasdada", "vvbvbv"));
            Console.WriteLine(p.Add(1, 2));
        }

    }
}
