using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_Biggest_of_Five_Numbers
{
    class Bigestnumbertwo
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter d");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter e");
            double e = double.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e )
            {

                Console.WriteLine("A is biger = {0}", a);


            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("B is biger  = {0}", b);

            }
            else if (c > a && c > b && c > d && c > e)

                Console.WriteLine("C is biger {0}", c);
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("D is biger {0}",d);
            
            }
            else
            {
                Console.WriteLine("E is biger {0}",e);


            }
                    
        }
    }
}
