/*
Розробити клас Person, який містить відповідні члени для зберігання:
імені, віку, статі і телефонного номера.
Напишіть функції-члени, які зможуть змінювати ці члени даних індивідуально. Напишіть функцію-член Person :: Print (), яка виводить відформатовані дані про людину.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex303
{
    enum person_sex
    {
        m,
        f
    }
    internal class Person
    {
        private string name;
        private int age;
        private person_sex sex;
        private string phone;

        public string Get_Name() { return name; }
        public void Set_Name (string _name) { name = _name; }
        public int Get_Age() { return age; }
        public void Set_Age (int _age) {
            if  (_age>0 && _age <120 ) age = _age;
            else 
            {
                Console.WriteLine("Error age. Age =  10");
                age = 10;
            }
        }
        public string Get_Phone() { return phone; }
        public void Set_Phone (string _phone) { phone = _phone; }
        public person_sex Get_sex() { return sex; }
        public string Get_sex_toString() 
        {
            if (sex == person_sex.m) return "male";
            else return "female";
        }
        public void Set_sex (person_sex _sex) { sex = _sex; }

        public Person(string _name, int _age, person_sex _sex)
        {
            this.name = _name;
            if (_age > 0 && _age < 120) age = _age;
            else
            {
                Console.WriteLine("Error age. Age =  10");
                age = 10;
            }
            this.sex = _sex;
            this.phone = "";
        }

        public Person(string _name, int _age, person_sex _sex, string _phone) 
        {
            this.name = _name;
            if (_age > 0 && _age < 120) age = _age;
            else
            {
                Console.WriteLine("Error age. Age =  10");
                age = 10;
            }
            this.sex = _sex;
            this.phone = _phone;
        }

        public string Print()
        {
            return "Info for person\nName  : "+ Get_Name() + "\nAge   : "+Get_Age()+"\nSex   : "+Get_sex_toString() + "\nPhone : "+Get_Phone();    
        }
    }
}
