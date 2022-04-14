using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex316
{
    internal class President:Employer
    {
        string secretarname;
        string modelcar;

        public President (string _firstname, string _lastname, int _salary, string _secretarname, string _modelcar)
            :base(_firstname,_lastname,_salary)
        {
            secretarname = _secretarname;
            modelcar = _modelcar;
        }

        public override void Say() 
        {
            Console.WriteLine("Say            : I am owner on this firm");
        }

        public override void Print()
        {
            Console.WriteLine("It is President");
            base.Print();
            Console.WriteLine("Secretar Name  : {0}\nModel car      : {1}",this.secretarname,this.modelcar);
        }
    }
}
