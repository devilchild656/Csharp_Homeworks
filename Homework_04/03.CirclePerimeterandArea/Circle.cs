using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterandArea
{
    class Circle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter r of cirlce");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * 2; ;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area is = {0}\nPerimeter is = {1:F2}", r,perimeter);

        }
    }
}
