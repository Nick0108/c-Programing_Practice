using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07Qu04
{
    class Program
    {
        enum orientation : byte
        {
            North = 1,
            South = 2,
            east = 3,
            west = 4
        }
        
        static void Main(string[] args)
        {
            byte myByte = 0;
            orientation myDirection = orientation.east;
            Console.WriteLine("Please enter 1-4 to select one direction:");
            string Userinput = Console.ReadLine();
            try
            {
                //if(myByte==1^ myByte == 2 ^ myByte == 3 ^ myByte == 4)
                    myByte = Convert.ToByte(Userinput);
            }
            catch
            {
                Console.WriteLine($"your input {Userinput} is not a viable number!");
            }
            finally
            {
                myDirection = checked((orientation)myByte);
                if(myByte==1^ myByte == 2 ^ myByte == 3 ^ myByte == 4)
                Console.WriteLine(myDirection);
                else
                Console.WriteLine($"your input {Userinput} is not round(1-4) number!");
            }
            Console.ReadKey();
        }
    }
}
