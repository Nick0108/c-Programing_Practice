using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch10Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Creating object myObj ... ");
            MyClass myObj = new MyClass("My Object");
            WriteLine("myObject created.");
            for(int i = -1; i <= 0; i++)
            {
                try
                {
                    WriteLine($"\nAttempting to assign {i} to myObj.Val ...");
                    myObj.Val = i;
                    WriteLine($"Value{myObj.Val} assigned to myObj.Val.");
                }
                catch (Exception e)
                {
                    WriteLine($"Exceptiom{e.GetType().FullName} thrown.");
                    WriteLine($"Message:\n\"{e.Message}\"");
                }
            }
            WriteLine("\nOutputting myObj.tostring()...");
            WriteLine(myObj.ToString());
            WriteLine("myObj.ToString() Output.");
            
            WriteLine("\nmyDoubleIntProp = 5 ...");
            WriteLine($"Getting myDoubleIntProp of 5 is {myObj.myDoubledIntProp}");

            ReadKey();
        }
    }
}
