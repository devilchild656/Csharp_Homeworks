using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Prime number");
            int number = int.Parse(Console.ReadLine());
            int br = 0;

            if (number <= 0)
            {

                Console.WriteLine("Prime number = {0}", false);
            }

            else
            {
                for (int i = number; i > 0; i--)
                {
                    if (number % i == 0) br++;

                }
                if (br == 2)

                    Console.WriteLine("Prime number = {0} ", true);

                if (br != 2)

                    Console.WriteLine("Prime number = {0}", false);

            }

        }
    }
}

