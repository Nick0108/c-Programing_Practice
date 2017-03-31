using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Qu01
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string cName,int cAge)
        {
            Name = cName;
            Age = cAge;
        }
        //重载 >, <, >=, <=
        public static bool operator >(Person person_1, Person person_2)
        {
            return (person_1.Age > person_2.Age);
        }
        public static bool operator <(Person person_1, Person person_2)
        {
            return (person_1.Age < person_2.Age);
        }
        public static bool operator >=(Person person_1, Person person_2)
        {
            return (person_1.Age >= person_2.Age);
        }
        public static bool operator <=(Person person_1, Person person_2)
        {
            return (person_1.Age <= person_2.Age);
        }
    }
}
