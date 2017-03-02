using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch04Qu02
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            do
            {
                WriteLine("Please give me a number:");
                firstNumber = ToInt32(ReadLine());
                WriteLine("please give me another number:");
                secondNumber = ToInt32(ReadLine());
                if((firstNumber > 10) && (secondNumber > 10))
                WriteLine("please make sure the two number must be one of them greater than 10!\nPlease give me two number again!");
            } while ((firstNumber > 10) && (secondNumber >10));
            WriteLine($"Your number are {firstNumber} and {secondNumber}");
            ReadKey();        
        }
    }
}
