using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate_N_K_secondpart
{
   
    class Factorial_N_K
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNAndK = 1;
        BigInteger result = 0;
       

        if (n > 1 && k > 1 && n < 100 && k < 100 && n > k)
        {
           
 
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                if(i <=k)
                {
                factK *= i;
                }
                if (i <= n - k)
                {
                    factNAndK *= i;
                
                }
     
               
            }
 
            result = factN / (factK * factNAndK);
 
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
        }
    }
