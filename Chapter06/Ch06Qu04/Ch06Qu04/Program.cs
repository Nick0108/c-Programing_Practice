using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Qu04
{
    class Program
    {
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;
            public double OrdertotalCost()
            {
                double totalCost = unitCount * unitCost;
                return totalCost;
            }
            public string outputline()
            {
                string line_output = $"Order Information: {unitCount} {itemName} items at ${unitCost} each, \ntotal cost ${OrdertotalCost()}";
                return line_output;
            }
        }
        static void Main(string[] args)
        {
            order item1;
            item1.itemName = "camera";
            item1.unitCount = 2;
            item1.unitCost = 2400;
            WriteLine(item1.outputline());
            ReadKey();
        }
    }
}
