using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitfromInteger
{
    class ExtractBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number "); 
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter P");
            int p = int.Parse(Console.ReadLine());
            string convert = Convert.ToString(Number, 2).PadLeft(16, '0');
            Console.WriteLine("Number code in Bits = {0}", convert);
            int Numberl = Convert.ToInt32(convert);
            int mask = 1;
            mask = mask << p;
            int secondmask = Number & mask;

            if (secondmask != 0)
            {

                Console.WriteLine("Bit position is {0} is 1", p);
            }
            else
            {
                Console.WriteLine("Bit position is {0} is 0",p);
            }



        }
    }
}
