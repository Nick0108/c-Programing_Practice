using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Qu03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+"===");
                if ((i % 2) == 0)
                    continue;
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}
