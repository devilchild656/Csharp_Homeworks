using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter n number ");
                int n = int.Parse(Console.ReadLine());
                int a = 0;
                int b = 1;
                int sum = 1;
                Console.WriteLine("--> 0\n--> 1");
                for (int i = 2; i < n; i++)

                {
                    sum = a + b ;
                    a = b;
                    b = sum;

                    Console.WriteLine("--> {0} " ,sum);
             
        }


            }
        }
    }

