using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch05Ex02
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte directionByte;
            string directionString;
            byte myByte = 3;
            orientation myDirection = orientation.north;
            myDirection = (orientation)myByte;
            WriteLine($"myDirection = {myDirection}");
            WriteLine($"typeof myDirection = {(myDirection.GetType())}");
            WriteLine($"typeof orientation = {(typeof(orientation))}");
            WriteLine($"myByte = {myByte}");
            WriteLine($"typeof myByte = {(myByte.GetType())}");
            WriteLine($"typeof myByte -> byte = {(typeof(byte))}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            WriteLine($"byte equivalent = {directionByte}");
            WriteLine($"string equivalent = {directionString}"); 
            ReadKey();
        }
    }      
}
