using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min_Max_Sum_and_Average_of_N_Numbers
{
    class Min_Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N numbers to enter");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            double average = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
                average = sum / n;
                
            }
            
                Console.WriteLine(@"
min = {0}
max = {1}
sum = {2}
aver = {3:F2}", min, max, sum, average);
            
        }
    }
}
