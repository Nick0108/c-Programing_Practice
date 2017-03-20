using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch10Qu04;

namespace Ch10Qu04Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCopyableClass testingA = new MyCopyableClass();
            string getStringdefaultA = "testA的默认值"+testingA.testingProp;
            testingA.testingProp = "A:改变testingA";

            MyCopyableClass testingB = testingA.GetCopy();

            //testingB.testingProp = "B:改变testingB";
            //string getStringdefaultAAfter = "这是改变testingB后的tesingA值:"+testingA.testingProp;
            //Console.WriteLine(getStringdefaultA + "==\n==="+testingA.testingProp+"=====\n==="+testingB.testingProp +"==\n==="+  getStringdefaultAAfter+"==\n===");
            testingA.testingProp = "A:再次改变testingA";
            Console.WriteLine(testingB.testingProp);
            Console.ReadKey();
        }
    }
}
