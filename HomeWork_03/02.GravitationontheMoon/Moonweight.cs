using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationontheMoon
{
    class Moonweight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you weight");
            double weight = Convert.ToDouble(Console.ReadLine());
            weight = weight * 0.17 ;
            Console.WriteLine("You weight on the moon is {0}",weight);

            
        }
    }
}
