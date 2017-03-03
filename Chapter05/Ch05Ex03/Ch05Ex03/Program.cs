using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch05Ex03
{
    enum orientation: byte  //定义 基本数据为type 的 枚举类orientation （枚举方向）
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    struct route //定义 结构类struct，存储 枚举方向 和 double距离 两类数据
    {
        public orientation  direction;
        public double       distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            route   myRoute;
            int     myDirection = -1;
            double  myDistance;               //以上三个是初始化 用户自定义的方向和距离
            WriteLine("1) North\n2) South\n3) East\n4) West");
            do
            {
                WriteLine("Select a direction:");
                myDirection = ToInt32(ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));   //循环强制用户输入一个代表方向的数字 ---> 放入 myDirection 中
            WriteLine("Input a distance:");
            myDistance = ToDouble(ReadLine());    //获得用户输入的距离  ---> 放入 myDistance 中
            myRoute.direction = (orientation)myDirection;  //将 myDirection 显性转化为 orientation 类，并将该类值赋予 myRoute 中的 direction
            myRoute.distance = myDistance;                 //将 myDistance 赋予 myRoute 中的 distance
            WriteLine($"myRoute specifies a direction of {myRoute.direction} " + 
                $"and a distance of {myRoute.distance}");   //输出 结构myRoute中的 myDirection 和 myDistance 值
            ReadKey();
        }
    }
}
