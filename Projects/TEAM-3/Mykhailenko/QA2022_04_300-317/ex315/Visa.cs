using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex315
{
    internal class Visa
    {
        public string Title { get; set; }   
        public DateTime date { get; set; }
        public Visa(string _title, DateTime _date)
        {
            Title = _title;
            date = _date;
        }
    }
}
