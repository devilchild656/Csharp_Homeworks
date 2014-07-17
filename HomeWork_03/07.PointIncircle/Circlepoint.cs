using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointIncircle
{
    class Circlepoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y <= 4)
            {
                Console.WriteLine("Point is in the circle = {0}", true);


            }
            else
            {
                Console.WriteLine("Point is in the circle = {0}",false);
            
            }



        }
    }
}
