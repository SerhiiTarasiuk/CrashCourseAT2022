using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex315
{
    internal class ForeignPassport:Passport
    {
        List<Visa> visalist;

        public ForeignPassport (string _firstname, string _lastname, DateTime _date, string _number, DateTime _datestart, DateTime _dateend)
            :base(_firstname, _lastname, _date, _number, _datestart, _dateend)
        {
            name = "ForeignPassportUkraine";
            visalist = new List<Visa>();
        }

        public void AddVisa ( Visa _v)
        {
            visalist.Add(_v);
        }
        public new string Print()
        {
            string tmp;
            tmp = base.Print() + "\n-Visa-";
            foreach (Visa v in visalist)
            {
                tmp += "\nCustoms post : "+v.Title+"\nDate         : "+v.date.ToShortDateString();
            }
            return tmp;
        }
    }
}
