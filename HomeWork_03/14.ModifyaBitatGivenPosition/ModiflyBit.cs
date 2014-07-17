using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyaBitatGivenPosition
{
    class ModiflyBit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
        string str = Console.ReadLine();
        int number = int.Parse(str);
        Console.WriteLine("Enter p");
        string strP = Console.ReadLine();
        int p = int.Parse(strP);
        Console.WriteLine("Enter 0 or 1");
        string strV = Console.ReadLine();
        int v = int.Parse(strV);
        int mask;
        int result;
        if (v == 0)
        {
            mask = ~(1 << p);
            result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            mask = 1 << p;
            result = number | mask;
            Console.WriteLine(result);
        }

            }
        }
    }


