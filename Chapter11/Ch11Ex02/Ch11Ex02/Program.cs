﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Kevin"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.feed();
            }
            Console.ReadKey();
        }
    }
}
