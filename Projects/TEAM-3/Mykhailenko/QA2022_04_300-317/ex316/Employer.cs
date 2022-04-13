using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex316
{
    internal abstract class Employer
    {
        string firstname;
        string lastname;
        int salary;

        public Employer(string _firstname, string _lastname, int _salary)
        {
            this.firstname = _firstname;
            this.lastname = _lastname;
            this.salary = _salary;
        }

        public abstract void Say();
        public virtual void Print ()
        {
            Console.WriteLine("First Name     : {0}\nLast Name      : {1}\nSalary         : {2}",this.firstname,this.lastname, this.salary);
        }
    }
}
