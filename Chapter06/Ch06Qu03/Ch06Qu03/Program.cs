using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Qu03
{
    class Program
    {
        delegate string Readitinline();
        static void Main(string[] args)
        {
            Readitinline readinline;
            //readinline = new Readitinline(ReadLine);
            readinline = ReadLine;
            WriteLine("please enter some words:");
            string words = readinline();
            WriteLine($"Here your words: {words}");
            ReadKey();
        }
    }
}
