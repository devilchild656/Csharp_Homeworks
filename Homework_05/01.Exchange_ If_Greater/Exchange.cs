using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  number");
            int b = int.Parse(Console.ReadLine());

            int c = 0;

            if (a > b)
            {
                c = b;
                b = a;
                a = c;

                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);


            }
        }
    }
}