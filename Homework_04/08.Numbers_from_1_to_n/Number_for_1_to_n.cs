using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Numbers_from_1_to_n
{
    class Number_for_1_to_n
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N number");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                
                Console.WriteLine(i);
                
            }
        }
    }
}
