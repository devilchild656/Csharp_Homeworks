using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Not_Divisible_by_3_and_7
{
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else 
                {
                    Console.Write(" {0}",i );
                }
            }

            Console.WriteLine();
        }
    }
}

    

