using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Binary_to_Decimal_Number
{
    class Binary_to_Decimal
    {
        static void Main(string[] args)
        {
           Console.Write("Enter your binary number: ");
        string binary = Console.ReadLine();
 
        long dec = 0;
 
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }
 
            dec += (long)(i * i);
        }
 
        Console.WriteLine(dec);
    }
        }
    }


