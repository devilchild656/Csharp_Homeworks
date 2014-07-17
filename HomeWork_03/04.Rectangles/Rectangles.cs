using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Width of Rectangle");
            int Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height  Rectangle ");
            int height = int.Parse(Console.ReadLine());
            int area = Width * height;
            int perimeter = 2*(Width * height);

            Console.WriteLine("The area is {0} * {1} = {2}",Width,height,area);
            Console.WriteLine("The peremeter is 2*({0} * {1}) = {2}", Width, height, perimeter);

        }
    }
}
