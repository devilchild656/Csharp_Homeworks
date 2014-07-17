using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Float ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Float ");
            float b = float.Parse(Console.ReadLine());
            float eps = 0.000001f;

            if (a > b)
            {
                bool first = (a - b < eps);
                Console.WriteLine(first);

            }
            else
            {
                bool second = (b - a < eps );
                Console.WriteLine("They are  equal = {0}",second);


            }

           

        }
    }
}
