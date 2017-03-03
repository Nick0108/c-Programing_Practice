using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Qu06
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inputwords = ReadLine();
            char[] separator = { ' ' };
            string[] wordArr = Inputwords.Split(separator);
            string output = "";
            for(int i = 0; i < wordArr.Length; i++)
            {
                int eachNumber = wordArr[i].ToCharArray().Length;
                if (eachNumber != 0)
                {
                    wordArr[i] = wordArr[i].PadLeft(eachNumber+1, '\"');
                    wordArr[i] = wordArr[i].PadRight(eachNumber+2, '\"');
                    output += (wordArr[i]+" ");
                }
            }
            WriteLine(output);
            ReadKey();       
        }
    }
}
