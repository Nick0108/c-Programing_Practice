using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex04
{
    class Checker
    {
        public void Check(object paraml)
        {
            if (paraml is ClassA)
                WriteLine("Variable can be convered to ClassA.");
            else
                WriteLine("Variable can't be convered to ClassA.");
            if (paraml is IMyInterface)
                WriteLine("Variable can be convered to IMyInterface.");
            else
                WriteLine("Variable can't be convered to IMyInterface.");
            if (paraml is Mystruct)
                WriteLine("Variable can be convered to MyStruct.");
            else
                WriteLine("Variable can't be convered to MyStruct.");
        }
    }
    interface IMyInterface { }
    class ClassA : IMyInterface { }
    class ClassB : IMyInterface { }
    class ClassC { }
    class ClassD : ClassA { }
    struct Mystruct : IMyInterface { }
    class Program
    {
        static void Main(string[] args)
        {
            Checker check = new Checker();
            ClassA try1 = new ClassA();
            ClassB try2 = new ClassB();
            ClassC try3 = new ClassC();
            ClassD try4 = new ClassD();
            Mystruct try5 = new Mystruct();
            object try6 = try5;
            WriteLine("Analyzing ClassA type variable:");
            check.Check(try1);
            WriteLine("\nAnalyzing ClassB type variable:");
            check.Check(try2);
            WriteLine("\nAnalyzing ClassC type variable:");
            check.Check(try3);
            WriteLine("\nAnalyzing ClassD type variable:");
            check.Check(try4);
            WriteLine("\nAnalyzing Mystruct type variable:");
            check.Check(try5);
            WriteLine("\nAnalyzing BOXED Mystruct type variable:");
            check.Check(try6);
            ReadKey();
        }
    }
}
