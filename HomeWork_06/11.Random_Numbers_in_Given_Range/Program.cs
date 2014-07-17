using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _11.Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("enter n numbers");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max");
          
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter min");
            int min = int.Parse(Console.ReadLine());
            //logic
            Random random = new Random();
            if (min <= max)
                for (int i = 0; i < n; i++)
                {
                    //output
                    Console.WriteLine("{0}", random.Next(min, max));
                }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
