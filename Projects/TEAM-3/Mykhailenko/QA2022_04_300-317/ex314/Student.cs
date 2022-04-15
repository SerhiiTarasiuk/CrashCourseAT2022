using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex314
{
    internal class Student
    {
        protected string name;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sp { get; set; }
        public int Kurs { get; set; }

        public Student (string _firstname, string _lastname, string _sp, int _kurs)
        {
            this.name = "-Student-";
            FirstName = _firstname;
            LastName = _lastname;
            Sp = _sp;
            Kurs = _kurs;
        }
        public string Print () 
        {
            return this.name+"\nFirstName     : "+this.FirstName+"\nLastName      : "+this.LastName+"\nSpecial       : "+this.Sp+"\nKurs          : "+this.Kurs;
        }
    }
}
