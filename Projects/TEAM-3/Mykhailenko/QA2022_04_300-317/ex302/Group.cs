using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex302
{
    internal class Group
    {
        List<Student> students;
        public string Name { get; set; }
        public string SpName { get; set; }
        public Group (string _name, string _sp) 
        {
            students = new List<Student> ();
            Name = _name;
            SpName = _sp;
        }
        public void AddStudent(string _firstname, string _lastname) { students.Add(new Student(_firstname, _lastname)); }
        public void AddStudent (Student _student) { students.Add(_student); }
        public double AgvMark(string _name) 
        {
            double sum = 0;
            int count = 0;

            foreach (Student student in students) { sum+=student.GetMark(_name); count++; }
            return sum/count;
        }

        public void PrintJornalGroup()
        {
            Console.WriteLine("Name group : {0}\t\tName Special : {1}",this.Name,this.SpName);
            foreach(Student student in students)
            {
                student.PrintInfoStudent();
            }
        }
    }
}
