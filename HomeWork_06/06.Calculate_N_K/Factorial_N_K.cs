using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Calculate_N_K
{
    class Factorial_N_K
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factn = 1;
            BigInteger factk = 1;
            BigInteger sum = 0;
            if (n > 1 && k > 1 && n < 100 && k < 100)
            {


                for (int i = 1; i <= n; i++)
                {

                    factn *= i;

                    if (i <= k)
                    {


                        factk *= i;
                    }
                }


                sum = factn / factk;
                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("invalid input");

            }
        }
    }
}
