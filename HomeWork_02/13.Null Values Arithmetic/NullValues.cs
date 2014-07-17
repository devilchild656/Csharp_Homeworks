using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Null_Values_Arithmetic
{
    class NullValues
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 5;
            b = null;
            Console.WriteLine(a);
            Console.WriteLine(b);


        }
    }
}
