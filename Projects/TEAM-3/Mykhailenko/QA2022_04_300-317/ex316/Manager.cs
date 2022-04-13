using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex316
{
    internal class Manager:Employer
    {
        int approom;

        public Manager(string _firstname, string _lastname, int _salary, int _approom) : base(_firstname, _lastname, _salary)
        {
            this.approom = _approom;
        }

        public override void Say()
        {
            Console.WriteLine("Say            : I am manager");
        }

        public override void Print()
        {
            Console.WriteLine("It is Manager");
            base.Print();
            Console.WriteLine("Number of room : {0}", this.approom);
        }
    }
}
