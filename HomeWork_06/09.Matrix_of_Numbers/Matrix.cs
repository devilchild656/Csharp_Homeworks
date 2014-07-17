using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n");
            int n = int.Parse(Console.ReadLine());

            if (n > 1 && n < 20)
            {
                for (int i = 1 ; i <= n; i++)
                {
                    for (int j = i; j <= n+i; j++)
                    {
                        
                        Console.Write(j+" ");
                        
                      
                    }
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}

                


