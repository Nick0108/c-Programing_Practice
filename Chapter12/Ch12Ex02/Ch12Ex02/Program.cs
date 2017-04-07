using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();
            animalCollection.Add(new Cow("Rual"));
            animalCollection.Add(new Chicken("Donnia"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.feed();
            }
            Console.ReadKey();
        }
    }
}
