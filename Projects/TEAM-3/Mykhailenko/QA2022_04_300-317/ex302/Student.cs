using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex302
{
    internal class Student
    {
        List<Predmet> predmets;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student (string _firstname, string _lastname)
        {
            predmets = new List<Predmet> ();
            FirstName = _firstname;
            LastName = _lastname;
        }
        public void AddPredmet(string _name, byte _mark) 
        {
            predmets.Add (new Predmet(_name,_mark ));
        }
        public byte GetMark (string _namepredmet) 
        {
            byte _mark = 0;
            foreach (Predmet predmet in predmets) 
            {
                if (predmet.Name == _namepredmet) _mark=predmet.Mark;
            }
            return _mark;
        }

        public void PrintInfoStudent() 
        {
            Console.WriteLine("Student First Name : {0}\tLast Name : {1}",this.FirstName, this.LastName);
            foreach (Predmet predmet in predmets)
            {
                if (predmet.Name.Length<7) Console.WriteLine("Predmet : {0}\t\t :{1}",predmet.Name,predmet.Mark);
                else Console.WriteLine("Predmet : {0}\t :{1}", predmet.Name, predmet.Mark);
            }
        }
    }
}
