using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Bitwise
{
    class Bits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int number = int.Parse(Console.ReadLine());
            string Converted = Convert.ToString(number, 2).PadLeft(16,'0');
            Console.WriteLine("binary code = {0} ",Converted);
            long digit = Convert.ToInt64(Converted);
            Console.WriteLine("3 number is = {0}",digit / 100 % 10);
            
        }
    }
}
