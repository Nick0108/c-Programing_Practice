using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Qu01
{
    class Program
    {
        static void Main(string[] args)
        {
            People mypeople = new People();
            mypeople.AddPerson(new Person("bei", 15));
            mypeople.AddPerson(new Person("jing", 19));
            mypeople.AddPerson(new Person("huan", 30));
            mypeople.AddPerson(new Person("ying", 11));
            mypeople.AddPerson(new Person("ni", 55));
            mypeople.AddPerson(new Person("can", 52));
            mypeople.AddPerson(new Person("jia", 55));
            mypeople.AddPerson(new Person("haha", 30));
            Console.WriteLine();
            foreach (int age in mypeople)
            {
                Console.WriteLine(age);
            }
            Person[] maxPeople = mypeople.GetOldest();
            for(int i =0; i< maxPeople.Length; i++)
            {
                Console.WriteLine($"{maxPeople[i].Name} : {maxPeople[i].Age}");
            }
            
            Console.ReadKey();
        }
    }
}
