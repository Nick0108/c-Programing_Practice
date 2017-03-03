using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            string mySrting = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = mySrting.Split(separator);
            foreach (string word in myWords)
            {
                WriteLine($"{word}");
            }
            ReadKey();
        }
    }
}
