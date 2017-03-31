using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Qu01
{
    public class People : DictionaryBase, ICloneable
    {
        public void AddPerson(Person person_1) 
        {
                string personName = person_1.Name;
                Dictionary.Add(personName, (object)person_1);
        }
        public void RemovePerson(string personName)
        {
            Dictionary.Remove(personName);
        }
        public Person this[string personName]
        {
            get { return (Person)Dictionary[personName]; }
            set { Dictionary[personName] = (object)value; }
        }
        public Person[] GetOldest()
        {
            int returnPersonNum = 1;
            int peopleNum = Dictionary.Count;
            Person[] peopleTemp = new Person[peopleNum];
            int people_index = 0;
            //构建一个包含全部person的person类的数组peopleTemp[]
            foreach (DictionaryEntry everyPerson in Dictionary)
            { 
                peopleTemp[people_index] = (Person)everyPerson.Value;
                people_index++;
            }
            Person maxPerson = peopleTemp[0];
            Person[] returnPeople = new Person[returnPersonNum];
            returnPeople[0] = maxPerson;
            for (int j = 0; j < peopleTemp.Length; j++)
            {
                if (peopleTemp[j] > maxPerson)
                {
                    maxPerson = peopleTemp[j];
                    returnPersonNum = 1;
                    returnPeople = new Person[returnPersonNum];
                    returnPeople[0] = maxPerson;
                }
                else if(peopleTemp[j].Age == maxPerson.Age)
                {
                    returnPersonNum++;
                    Person[] returnPeople_Temp = new Person[returnPersonNum];
                    returnPeople.CopyTo(returnPeople_Temp, 0);
                    returnPeople_Temp[returnPersonNum - 1] = peopleTemp[j];
                    returnPeople = returnPeople_Temp;
                }
            }
            return returnPeople;
        }
        public object Clone()
        {
            People cloner = new People();
            return cloner;
        }
        public new IEnumerator GetEnumerator()
        {
            foreach (object EveryPerson in Dictionary.Values)
                yield return ((Person)EveryPerson).Age;
        }
    }
}
