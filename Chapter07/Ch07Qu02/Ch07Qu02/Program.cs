using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07Qu02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number4999 = new int[4999];
            Console.WriteLine(Number4999[3002]);
            for(int i =0; i < 5000; i++)
            {
                Number4999[i] += i;  
            }
            //Console.WriteLine(Number4999[3002]);
            Console.ReadKey();
        }
    }
}
