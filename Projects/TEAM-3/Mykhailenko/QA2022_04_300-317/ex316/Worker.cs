using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex316
{
    internal class Worker:Employer
    {
        string department;
        public Worker(string _firstname, string _lastname, int _salary, string _department) : base(_firstname, _lastname, _salary)
        {
            this.department = _department;
        }

        public override void Say()
        {
            Console.WriteLine("Say            : I am simply worker");
        }

        public override void Print()
        {
            Console.WriteLine("It is Worker");
            base.Print();
            Console.WriteLine("Department     : {0}", this.department);
        }

    }
}
