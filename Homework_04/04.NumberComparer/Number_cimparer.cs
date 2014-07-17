using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class Number_cimparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b ");
            double b = double.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("b is bigger then a = {0} > {1} ",b,a);

            }
            else
            {
                Console.WriteLine("a is bigger then b = {0} > {1}",a,b);
            
            }

        }
    }
}
