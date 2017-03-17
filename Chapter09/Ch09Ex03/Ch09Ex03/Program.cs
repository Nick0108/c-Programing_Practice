using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch09Ex03
{
    class myClass
    {
        public int val; 
    }
    struct myStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass objectA = new myClass();
            myClass objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;
            myStruct sturctA = new myStruct();
            myStruct sturctB = sturctA;
            sturctA.val = 30;
            sturctB.val = 40;
            WriteLine($"objectA.val = {objectA.val}");
            WriteLine($"objectB.val = {objectB.val}");
            WriteLine($"sturctA.val = {sturctA.val}");
            WriteLine($"sturctB.val = {sturctB.val}");
            ReadKey();
        }
    }
}
