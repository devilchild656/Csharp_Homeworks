using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class Fourdigitnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int numbers = int.Parse(Console.ReadLine());
            int a = numbers / 1000 % 10;
            int b = numbers / 100 % 10;
            int c = numbers / 10 % 10;
            int d = numbers / 1 % 10;
            if (a != 0)
            {
                Console.WriteLine("The sum is {0}+{1}+{2}+{3}={4}", a, b, c, d, a + b + c + d);
                Console.WriteLine(d + " " + a + " " + b + " " + c);
                Console.WriteLine(a + " " + c + " " + b + " " + d);

            }

            else
            {
                Console.WriteLine("you can't start with 0");
            }












        }
    }
}

