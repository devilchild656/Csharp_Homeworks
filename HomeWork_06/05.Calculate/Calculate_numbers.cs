using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n intiger");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the x intiger");
            int x = int.Parse(Console.ReadLine());
            double factN = 1;
            double multiX = 1;
            double result = 1;
        
                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                    multiX *= x;
                    result += factN / multiX;
                }

                Console.WriteLine("{0:F5}", result);
                
            }


        }
    }
