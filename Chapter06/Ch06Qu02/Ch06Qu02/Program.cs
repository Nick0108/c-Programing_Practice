using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch06Qu02
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) {
                WriteLine("The data is required");
                return;
            }
            string UserName = args[0];
            int UserNmuber = ToInt32(args[1]);
            WriteLine($"{UserName}  {UserNmuber}");
            ReadKey();
        }
    }
}
