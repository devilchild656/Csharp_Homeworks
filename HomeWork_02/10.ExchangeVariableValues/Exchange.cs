using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ExchangeVariableValues
{
    class Exchange
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            object ab = (int)a;
            object ba = (int)b;

            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
            Console.WriteLine("After Exchange");
            Console.WriteLine("a = {0}",a=(int)ba);
            Console.WriteLine("b = {0}",b=(int)ab);

                

                
        }
    }
}
