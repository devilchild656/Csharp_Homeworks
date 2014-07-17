using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_from_1_to_N
{
    class N_Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n number");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.Write("{0} ",i);
                
            }
        }
    }
}
