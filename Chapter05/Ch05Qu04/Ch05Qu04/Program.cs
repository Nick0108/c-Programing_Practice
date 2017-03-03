using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Qu04
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please input some words:");
            string UserInput = ReadLine();
            //WriteLine(UserInput);
            char[] UserInput_charArr = UserInput.ToCharArray();
            string Output = "";
            int j;
            //const int InputNumber = UserInput_charArr.Length;
            int UserInput_number = UserInput_charArr.Length;
            //WriteLine(UserInput_number);
            for (int i = 0; i < UserInput_number; i++)
            {
                j = UserInput_number - i -1;
                //WriteLine("here");
                Output += UserInput_charArr[j];
                //WriteLine(Output);
            }
            WriteLine("Your words is oppsite by follow:"+ $"\n{Output}");
            ReadKey();
        }
    }
}
