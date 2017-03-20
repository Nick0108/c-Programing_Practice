using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;
        public int State
        {
            get
            {
                return state;
            }
        }
        public class classB
        {
            public void SetPrivateState(ClassA target,int newState)
            {
                target.state = newState;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA myobject = new ClassA();
            WriteLine($"myObject.State = {myobject.State}");
            ClassA.classB myOtherObject = new ClassA.classB();
            myOtherObject.SetPrivateState(myobject,999);
            WriteLine($"myObject.State = {myobject.State}");
            ReadKey();
        }
    }
}
