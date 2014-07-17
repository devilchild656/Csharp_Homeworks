using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _16.Decimal_to_Hexadecimal_Number
{
    class Decimal_to_Hexa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter decimal number");
            long number = long.Parse(Console.ReadLine());
            string converted = System.Convert.ToString(number, 16);
            Console.WriteLine(converted);
     


        }
    }
}