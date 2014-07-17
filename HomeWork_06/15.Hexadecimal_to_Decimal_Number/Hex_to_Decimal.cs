using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _15.Hexadecimal_to_Decimal_Number
{
    class Hex_to_Decimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hexadecimal number");
            string hex = Console.ReadLine();
            decimal converted = Convert.ToInt64(hex,16);
            Console.WriteLine(converted);

        }
    }
}
