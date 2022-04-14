using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex314
{
    internal class Aspirant:Student
    {
        public string TitleWork { get; set; }
        public string SupervisorName { get; set; }

        public Aspirant (string _firstname, string _lastname, string _sp, int _kurs, string _titlework, string supervisorname) : base(_firstname, _lastname, _sp, _kurs) 
        {
            this.name = "-Aspirant-";
            TitleWork = _titlework;
            SupervisorName = supervisorname;
        }

        public new string Print ()
        {
            return base.Print () + "\nTitleWork     : "+this.TitleWork+"\nSuperviorName : "+this.SupervisorName;
        }
    }
}
