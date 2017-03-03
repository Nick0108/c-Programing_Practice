using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please input some words and I will turn no into yes");
            string inputStr = ReadLine();
            string output = "";
            string output_in;
            char[] separator = { 'n' };
            string[] inputStrArr_sp = inputStr.Split(separator);
            int sp_num = inputStrArr_sp.Length;
            char[] ourput_charArry;
            for (int i = 0; i < sp_num; i++)
            {
                char[] Each_sp_charArr = inputStrArr_sp[i].ToCharArray();
                if (Each_sp_charArr.Length == 0)
                {
                    output += "n";
                }
                else if (Each_sp_charArr[0] == 'o')
                {
                    output_in = "yes";
                    for (int j = 1; j < Each_sp_charArr.Length; j++)
                    {
                        output_in += Each_sp_charArr[j];
                    }
                    output += output_in;
                }
                else
                {
                    output_in = "n";
                    for (int j = 0; j < Each_sp_charArr.Length; j++)
                    {
                        output_in += Each_sp_charArr[j];
                    }
                    output += output_in;

                }
            }
            ourput_charArry = output.ToCharArray();
            if (ourput_charArry[0] == 'n')
            {
                output = "";
                for (int k = 1; k < ourput_charArry.Length; k++)
                {
                    output += ourput_charArry[k];
                }
            }
            WriteLine("Oh, you only can say yes");
            WriteLine(output);
            ReadKey();
        }
    }
}