using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex315
{
    internal class Passport
    {
        protected string name;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime date { get; set; }
        public string Number { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

        public Passport(string _firstname, string _lastname, DateTime _date, string _number, DateTime _datestart, DateTime _dateend)
        {
            this.name = "PassportUkraine";
            FirstName = _firstname;
            LastName = _lastname;
            date = _date;
            Number = _number;
            dateStart = _datestart;
            dateEnd = _dateend;
        }
        public string Print()
        {
            return this.name + "\nFirstName     : " + this.FirstName + "\nLastName      : " + this.LastName + "\nDate of birth : " + this.date.ToShortDateString() + "\nNumber        : " + this.Number + "\nDate start    : "+this.dateStart.ToShortDateString()+ "\nDate end      : " + this.dateEnd.ToShortDateString();
        }
    }
}
