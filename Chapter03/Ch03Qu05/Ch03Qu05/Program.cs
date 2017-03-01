using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03Qu05
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;
            string UserName;
            Console.WriteLine("Give me your name :");
            UserName = Console.ReadLine();
            Console.WriteLine($"Welcome {UserName}!");
            Console.WriteLine("Give me the first Number:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the second Number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the third Number:");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the fourth Number:");
            fourthNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The product of {firstNumber}, {secondNumber}, {thirdNumber}, {fourthNumber} is {firstNumber * secondNumber * thirdNumber * fourthNumber}.");
            Console.ReadKey();
        }
    }
}
