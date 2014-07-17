using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapetz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter h ");
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) / 2 * h;
            Console.WriteLine("The area is {0}",area);
        }
    }
}
