using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Ch09ClassLib;

namespace Ch09Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExtemalClass myObj = new MyExtemalClass();
            //MyInternalClass myObj = new MyInternalClass(); 只能内部访问，外部无法访问
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}
