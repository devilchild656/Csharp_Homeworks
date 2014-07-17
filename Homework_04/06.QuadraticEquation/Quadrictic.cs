using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class Quadrictic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c ");
            double c = Double.Parse(Console.ReadLine());
            double Sqr = (b * b) - 4 * a * c;

            if (Sqr < 0)
            {

                Console.WriteLine("No real roots");
            }
            else if  (Sqr > 0)
            { 
                double x1,x2 ;
                x1 = (-b - Math.Sqrt(Sqr)) / (2 * a);
                x2 = (-b + Math.Sqrt(Sqr)) / (2 * a);
                Console.WriteLine("x1={0}\nx2={1}",x1,x2);
                       
            }
            else if (Sqr == 0)
            {
                double x1,x2;
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("The only solution is x={0}.", x1);
                Console.ReadLine();
            
            }
            

          
        }
    }

}