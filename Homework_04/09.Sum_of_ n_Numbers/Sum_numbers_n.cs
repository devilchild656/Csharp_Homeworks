using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of__n_Numbers
{
    class Sum_numbers_n
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many n numbers do you want enter");
            int a = int.Parse(Console.ReadLine());
            double numbers;
            double sum = 0;
            for (int i = 0; i < a; i++)
            {
               
                numbers = double.Parse(Console.ReadLine());
                sum = sum + numbers;
                
            }

            Console.WriteLine(sum);
        }
    }
}
