using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideaCircleOutsideofaRectangle
{
    class CircleandRectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y");
            double y = double.Parse(Console.ReadLine());

            if (y <= 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)
                    Console.WriteLine("Point is in the Circle");


                else


                    Console.WriteLine("Not in the circle");
            }
            

        }
    }
}
