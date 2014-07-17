using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestof3Numbers
{
    class BigestNumberone
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                
                Console.WriteLine("A is biger = {0}",a);
                         
            
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is biger  = {0}",b);

            }
            else 
           
                    Console.WriteLine("C is biger {0}",c);
                    
                    
    }
        }
}
